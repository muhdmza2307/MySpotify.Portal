using Blazored.LocalStorage;
using Flurl.Http;
using MySpotify.Portal.Common.Configurations;
using MySpotify.Portal.Models.ResponseModels;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySpotify.Portal.DataServices.Spotify.Api
{
    public class SpotifyTokenProvider : ISpotifyTokenProvider
    {
        private const string AccessTokenKey = "spotify_access_token";
        private const string RefreshTokenKey = "spotify_refresh_token";
        private const string TokenExpiryKey = "spotify_token_expiry";

        private readonly ILocalStorageService _localStorage;
        private readonly SpotifyOptions _spotifyOptions;

        public SpotifyTokenProvider(ILocalStorageService localStorage,
            SpotifyOptions spotifyOptions)
        {
            _localStorage = localStorage;
            _spotifyOptions = spotifyOptions;
        }

        public async Task<string> GetLoginTokenAsync(string authCode)
        {
            var clientCredentials = $"{_spotifyOptions.ClientId}:{_spotifyOptions.ClientSecret}";
            var encodedCredentials = Convert.ToBase64String(Encoding.UTF8.GetBytes(clientCredentials));

            var input = GenerateNewAccessTokenInput(_spotifyOptions.RedirectUri, "authorization_code", authCode);

            var tokenResponse = await _spotifyOptions.TokenUri
                    .WithHeader("Authorization", $"Basic {encodedCredentials}")
                    .WithHeader("Content-Type", "application/x-www-form-urlencoded")
                    .PostUrlEncodedAsync(input)
                    .ReceiveJson<TokenResponse>()
                    .ConfigureAwait(false);

            await SetAccessToken(tokenResponse.AccessToken!);
            await SetRefreshToken(tokenResponse.RefreshToken!);
            await SetTokenExpiryDate(DateTime.UtcNow.AddSeconds((double)(tokenResponse.ExpiresIn! - 60)));

            return tokenResponse.AccessToken!;
        }

        public async Task<string> GetContinuousTokenAsync()
        {
            var tokenExpiry = await GetLocalTokenExpiry();

            if (await HasLocalAccessToken() || IsTokenExpired())
            {
                return await GetLocalAccessToken();
            }
            else
            {
                var input = GenerateRefreshTokenInput(_spotifyOptions.ClientId, "refresh_token", await GetLocalRefreshTokenAsync());

                var tokenResponse = await _spotifyOptions.TokenUri
                        .WithHeader("Content-Type", "application/x-www-form-urlencoded")
                        .PostUrlEncodedAsync(input)
                        .ReceiveJson<TokenResponse>()
                        .ConfigureAwait(false);

                await SetAccessToken(tokenResponse.AccessToken!);
                await SetRefreshToken(tokenResponse.RefreshToken!);
                await SetTokenExpiryDate(DateTime.UtcNow.AddSeconds((double)(tokenResponse.ExpiresIn! - 60)));

                return tokenResponse.AccessToken!;
            }


            //Local Function
            bool IsTokenExpired() =>
                tokenExpiry == null || DateTime.UtcNow >= tokenExpiry;
        }

        private async Task<string> GetLocalRefreshTokenAsync()
        {
            return await _localStorage.GetItemAsync<string>(RefreshTokenKey) ?? "";
        }

        private static IDictionary<string, string> GenerateNewAccessTokenInput(string redirectUri, string grantType, string authCode)
        {
            var dictionaryInput = new Dictionary<string, string>
            {
                { "grant_type", grantType },
                { "code", authCode },
                { "redirect_uri", redirectUri }
            };

            return dictionaryInput;
        }

        private async Task SetAccessToken(string token) => 
            await _localStorage.SetItemAsync(AccessTokenKey, token);

        private async Task SetRefreshToken(string token) =>
            await _localStorage.SetItemAsync(RefreshTokenKey, token);

        private async Task SetTokenExpiryDate(DateTime dateExpiry) =>
            await _localStorage.SetItemAsync(TokenExpiryKey, dateExpiry);

        private async Task<bool> HasLocalAccessToken()
        {
            var token = await _localStorage.GetItemAsync<string>(AccessTokenKey);
            return !string.IsNullOrEmpty(token);
        }
        private async Task<string> GetLocalAccessToken() => 
            await _localStorage.GetItemAsync<string>(AccessTokenKey) ?? "";

        private static IDictionary<string, string> GenerateRefreshTokenInput(string clientId, string grantType, string refreshToken)
        {
            var dictionaryInput = new Dictionary<string, string>
            {
                { "grant_type", grantType },
                { "code", refreshToken },
                { "client_id", clientId }
            };

            return dictionaryInput;
        }

        private async Task<DateTime?> GetLocalTokenExpiry()
        {
            var expiryStr = await _localStorage.GetItemAsync<string>(TokenExpiryKey);
            return DateTime.TryParse(expiryStr, out var expiry) ? (DateTime?)expiry : null;
        }
    }
}

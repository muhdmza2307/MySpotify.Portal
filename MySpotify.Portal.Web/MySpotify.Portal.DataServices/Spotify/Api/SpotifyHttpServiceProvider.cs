using MySpotify.Portal.Common.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySpotify.Portal.DataServices.Spotify.Api
{
    public class SpotifyHttpServiceProvider : ISpotifyHttpServiceProvider
    {
        private readonly SpotifyOptions _spotifyOptions;
        private readonly ISpotifyTokenProvider _spotifyTokenProvider;

        public SpotifyHttpServiceProvider(SpotifyOptions spotifyOptions, 
            ISpotifyTokenProvider spotifyTokenProvider)
        {
            _spotifyOptions = spotifyOptions;
            _spotifyTokenProvider = spotifyTokenProvider;
        }

        public async Task<ISpotifyGetService<TResponse>> GetServiceAsync<TResponse>() =>
            new SpotifyGetService<TResponse>(
                    _spotifyOptions.BaseUri,
                     await GetTokenAsync());

        public async Task<ISpotifyPostService> PostServiceAsync() => new SpotifyPostService(
                _spotifyOptions.BaseUri,
                await GetTokenAsync());

       

        private async Task<string> GetTokenAsync()
        {
            var tokenResponse = await _spotifyTokenProvider
                .GetContinuousTokenAsync().ConfigureAwait(false);

            return tokenResponse;
        }
    }
}

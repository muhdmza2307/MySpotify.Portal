using Flurl;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MySpotify.Portal.DataServices.Spotify.Api
{
    public class SpotifyGetService<TResponse> : SpotifyHttpService, ISpotifyGetService<TResponse>
    {
        public SpotifyGetService(string baseUri, string token) 
            : base(baseUri, token)
        {
        }

        /*public async Task<TResponse> GetAsync(string pathSegment, object? queryParameters = null) => 
            await BaseUri
            .WithOAuthBearerToken(Token)
            .SetQueryParams(queryParameters)
            .AppendPathSegment(pathSegment)
            .GetJsonAsync<TResponse>()
            .ConfigureAwait(false);*/

        public async Task<TResponse> GetAsync(string pathSegment, object? queryParameters = null) => 
            await BaseUri
            .WithOAuthBearerToken(Token)
            .SetQueryParams(queryParameters)
            .AppendPathSegment(pathSegment)
            .GetJsonAsync<TResponse>()
            .ConfigureAwait(false);
    }
}

using Flurl.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySpotify.Portal.DataServices.Spotify.Api
{
    public class SpotifyPostService : SpotifyHttpService, ISpotifyPostService
    {
        public SpotifyPostService(string baseUri, string token) 
            : base(baseUri, token)
        {
        }

        public async Task<TResponse> PostAsync<TInput, TResponse>(string pathSegment, TInput input)
        {
            return JsonConvert.DeserializeObject<TResponse>(await ExecutePostAsync());


            //LocalFunction
            async Task<string> ExecutePostAsync() =>
                await BaseUri
                    .WithOAuthBearerToken(Token)
                    .AppendPathSegment(pathSegment)
                    .WithHeader("Content-Type", "application/x-www-form-urlencoded")
                    .PostUrlEncodedAsync(input)
                    .ReceiveString()
                    .ConfigureAwait(false);
        }
    }
}

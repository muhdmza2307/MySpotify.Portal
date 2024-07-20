using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySpotify.Portal.DataServices.Spotify.Api
{
    public interface ISpotifyPostService
    {
        Task<TResponse> PostAsync<TInput, TResponse>(string pathSegment, TInput input);
    }
}

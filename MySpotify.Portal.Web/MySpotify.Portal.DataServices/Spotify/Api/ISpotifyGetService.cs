using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySpotify.Portal.DataServices.Spotify.Api
{
    public interface ISpotifyGetService<TResponse>
    {
        Task<TResponse> GetAsync(string pathSegment, object? queryParameters = null);
    }
}

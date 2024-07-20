using MySpotify.Portal.Common.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySpotify.Portal.DataServices.Spotify.Api
{
    public interface ISpotifyHttpServiceProvider
    {
        Task<ISpotifyGetService<TResponse>> GetServiceAsync<TResponse>();

        Task<ISpotifyPostService> PostServiceAsync();
    }
}

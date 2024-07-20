using MySpotify.Portal.Models.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySpotify.Portal.DataServices.Spotify.Api
{
    public interface ISpotifyTokenProvider
    {
        Task<string> GetLoginTokenAsync(string authCode);
        Task<string> GetContinuousTokenAsync();
    }
}

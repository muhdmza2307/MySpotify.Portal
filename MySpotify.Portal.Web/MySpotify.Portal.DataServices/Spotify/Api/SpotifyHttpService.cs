using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySpotify.Portal.DataServices.Spotify.Api
{
    public abstract class SpotifyHttpService
    {
        protected string BaseUri { get; }
        protected string Token { get; }

        protected SpotifyHttpService(string baseUri, string token)
        {
            BaseUri = baseUri;
            Token = token;
        }
    }
}

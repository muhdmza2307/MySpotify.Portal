using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySpotify.Portal.Common.Configurations
{
    public class SpotifyOptions
    {
        public string AuthorizeUri { get; set; } = null!;

        public string TokenUri { get; set; } = null!;

        public string BaseUri { get; set; } = null!;

        public string RedirectUri { get; set; } = null!;

        public string ClientId { get; set; } = null!;

        public string ClientSecret { get; set; } = null!;

        public string Scopes { get; set; } = null!;
    }
}

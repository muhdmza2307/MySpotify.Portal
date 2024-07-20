using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MySpotify.Portal.Models.ResponseModels
{
    public class ExternalUrls
    {
        [JsonProperty("spotify")]
        public string Spotify { get; set; } = null!;
    }
}

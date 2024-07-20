using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MySpotify.Portal.Models.ResponseModels
{
    public class PlaylistResponse
    {
        [JsonProperty("message")] 
        public string? Message { get; set; }

        [JsonProperty("playlists")] 
        public Playlists? Playlists { get; set; }
    }
}

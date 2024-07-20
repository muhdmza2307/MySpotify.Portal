using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MySpotify.Portal.Models.ResponseModels
{
    public class Image
    {
        [JsonProperty("url")]
        public string? Url { get; set; } = null!;

        [JsonProperty("height")] 
        public int? Height { get; set; }

        [JsonProperty("width")] 
        public int? Width { get; set; }
    }
}

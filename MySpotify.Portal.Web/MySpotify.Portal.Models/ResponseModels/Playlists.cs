using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MySpotify.Portal.Models.ResponseModels
{
    public class Playlists
    {
        [JsonProperty("href")]
        public string? Href { get; set; }

        [JsonProperty("items")]
        public IEnumerable<Item>? Items { get; set; }

        [JsonProperty("limit")]
        public int? Limit { get; set; }

        [JsonProperty("next")]
        public string? Next { get; set; }

        [JsonProperty("offset")]
        public int? Offset { get; set; }

        [JsonProperty("previous")]
        public object? Previous { get; set; }

        [JsonProperty("total")]
        public int? Total { get; set; }
    }

}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MySpotify.Portal.Models.ResponseModels
{
    public class LinkedFrom
    {
        [JsonProperty("external_urls")]
        public ExternalUrls ExternalUrls { get; set; } = null!;

        [JsonProperty("href")]
        public string Href { get; set; } = null!;

        [JsonProperty("id")]
        public string Id { get; set; } = null!;

        [JsonProperty("type")]
        public string Type { get; set; } = null!;

        [JsonProperty("uri")]
        public string Uri { get; set; } = null!;
    }
}

﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MySpotify.Portal.Models.ResponseModels
{
    public class Artist
    {
        [JsonProperty("external_urls")]
        public ExternalUrls? ExternalUrls { get; set; }

        [JsonProperty("href")] 
        public string? Href { get; set; }

        [JsonProperty("id")] 
        public string? Id { get; set; }

        [JsonProperty("name")] 
        public string? Name { get; set; }

        [JsonProperty("type")] 
        public string? Type { get; set; }

        [JsonProperty("uri")] 
        public string? Uri { get; set; }
    }
}

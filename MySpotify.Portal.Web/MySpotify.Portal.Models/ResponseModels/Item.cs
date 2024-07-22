﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MySpotify.Portal.Models.ResponseModels
{
    public class Item
    {
        [JsonProperty("collaborative")] public bool? Collaborative { get; set; }
        [JsonProperty("description")] public string? Description { get; set; }
        [JsonProperty("external_urls")] public ExternalUrls? ExternalUrls { get; set; }
        [JsonProperty("followers")] public Followers? Followers { get; set; }
        [JsonProperty("genres")] public List<string>? Genres { get; set; }
        [JsonProperty("href")] public string? Href { get; set; }
        [JsonProperty("id")] public string? Id { get; set; }
        [JsonProperty("images")] public IEnumerable<Image>? Images { get; set; }
        [JsonProperty("name")] public string? Name { get; set; }
        [JsonProperty("owner")] public Owner? Owner { get; set; }
        [JsonProperty("popularity")] public int? Popularity { get; set; }
        [JsonProperty("primary_color")] public string? PrimaryColor { get; set; }
        [JsonProperty("public")] public bool? Public { get; set; }
        [JsonProperty("snapshot_id")] public string? SnapshotId { get; set; }
        [JsonProperty("tracks")] public Tracks? Tracks { get; set; }
        [JsonProperty("type")] public string? Type { get; set; }
        [JsonProperty("uri")] public string? Uri { get; set; }
    }
}

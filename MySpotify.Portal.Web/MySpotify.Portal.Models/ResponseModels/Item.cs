using Newtonsoft.Json;
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
        /*[JsonProperty("added_at")]
        public string? AddedAt { get; set; }

        [JsonProperty("album")]
        public Album? Album { get; set; }

        [JsonProperty("artists")]
        public IEnumerable<Artist>? Artists { get; set; }

        [JsonProperty("available_markets")]
        public IEnumerable<string>? AvailableMarkets { get; set; }

        [JsonProperty("disc_number")]
        public int? DiscNumber { get; set; }

        [JsonProperty("duration_ms")]
        public int? DurationMs { get; set; }

        [JsonProperty("explicit")]
        public bool? Explicit { get; set; }

        [JsonProperty("external_urls")]
        public ExternalUrls? ExternalUrls { get; set; }

        [JsonProperty("href")]
        public string? Href { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("is_playable")]
        public bool? Isplayable { get; set; }

        [JsonProperty("linked_from")]
        public LinkedFrom? LinkedFrom { get; set; }

        [JsonProperty("restrictions")]
        public Restrictions? Restrictions { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("preview_url")]
        public string? PreviewUrl { get; set; }

        [JsonProperty("track_number")]
        public int? TrackNumber { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("uri")]
        public string? Uri { get; set; }

        [JsonProperty("is_local")]
        public bool? IsLocal { get; set; }*/


        [JsonProperty("collaborative")] 
        public bool? Collaborative { get; set; }
        [JsonProperty("description")] public string? Description { get; set; }
        [JsonProperty("external_urls")] public ExternalUrls? ExternalUrls { get; set; }
        [JsonProperty("href")] public string? Href { get; set; }
        [JsonProperty("id")] public string? Id { get; set; }
        [JsonProperty("images")] public IEnumerable<Image>? Images { get; set; }
        [JsonProperty("name")] public string? Name { get; set; }
        [JsonProperty("owner")] public Owner? Owner { get; set; }
        [JsonProperty("primary_color")] public string? PrimaryColor { get; set; }
        [JsonProperty("public")] public bool? Public { get; set; }
        [JsonProperty("snapshot_id")] public string? SnapshotId { get; set; }
        [JsonProperty("tracks")] public Tracks? Tracks { get; set; }
        [JsonProperty("type")] public string? Type { get; set; }
        [JsonProperty("uri")] public string? Uri { get; set; }
    }

}

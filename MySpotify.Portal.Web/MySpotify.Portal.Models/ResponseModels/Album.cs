using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MySpotify.Portal.Models.ResponseModels
{
    public class Album
    {
        [JsonProperty("album_type")]
        public string? AlbumType { get; set; }

        [JsonProperty("total_tracks")]
        public int? TotalTracks { get; set; }

        [JsonProperty("available_markets")]
        public IEnumerable<string>? AvailableMarkets { get; set; }

        [JsonProperty("external_urls")]
        public ExternalUrls? ExternalUrls { get; set; }

        [JsonProperty("href")]
        public string? Href { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("images")]
        public IEnumerable<Image>? Images { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("release_date")]
        public string? ReleaseDate { get; set; }

        [JsonProperty("release_date_precision")]
        public string? ReleaseDatePrecision { get; set; }

        [JsonProperty("restrictions")]
        public Restrictions? Restrictions { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("uri")]
        public string? Uri { get; set; }

        [JsonProperty("artists")]
        public IEnumerable<Artist>? Artists { get; set; }

        [JsonProperty("tracks")]
        public Tracks? Tracks { get; set; }

        [JsonProperty("copyrights")]
        public IEnumerable<Copyright>? Copyrights { get; set; }

        [JsonProperty("external_ids")]
        public ExternalIds? ExternalIds { get; set; }

        [JsonProperty("genres")]
        public IEnumerable<string>? Genres { get; set; }

        [JsonProperty("label")]
        public string? Label { get; set; }

        [JsonProperty("popularity")]
        public int? Popularity { get; set; }
    }
}

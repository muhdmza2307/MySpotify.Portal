using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySpotify.Portal.Models.ResponseModels
{
    public class Artists
    {
        [JsonProperty("href")] public string? Href { get; set; }
        [JsonProperty("limit")] public int? Limit { get; set; }
        [JsonProperty("next")] public object? Next { get; set; }
        [JsonProperty("cursors")] public Cursors? Cursors { get; set; }
        [JsonProperty("total")] public int? Total { get; set; }
        [JsonProperty("items")] public IEnumerable<Item>? Items { get; set; }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySpotify.Portal.Models.ResponseModels
{
    public class Followers
    {
        [JsonProperty("href")] 
        public object? Href { get; set; }

        [JsonProperty("total")] 
        public int? Total { get; set; }
    }
}

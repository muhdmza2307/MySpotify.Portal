using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySpotify.Portal.Models.ResponseModels
{
    public class FollowedArtistsResponse
    {
        [JsonProperty("artists")] public Artists? Artists { get; set; }
    }
}

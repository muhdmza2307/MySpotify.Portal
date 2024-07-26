using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySpotify.Portal.Models.ResponseModels
{
    public class Cursors
    {
        [JsonProperty("after")] 
        public object After { get; set; }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon.Dto
{
    public class Sprites
    {
        [JsonProperty("back_default")]
        public string Back_Default { get; set; }


        [JsonProperty("front_default")]
        public string Front_Default { get; set; }
    }
}

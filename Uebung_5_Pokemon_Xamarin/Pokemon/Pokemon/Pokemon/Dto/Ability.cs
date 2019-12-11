using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Pokemon.Dto
{
    public class Ability
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}

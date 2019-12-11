using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon.Dto
{
    public class PokemonUrl
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}

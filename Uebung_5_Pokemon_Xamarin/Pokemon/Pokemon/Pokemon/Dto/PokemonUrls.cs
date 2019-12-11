using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon.Dto
{
    public class PokemonUrls
    {
        [JsonProperty("urls")]
        public PokemonUrl[] urls { get; set; }
    }
}

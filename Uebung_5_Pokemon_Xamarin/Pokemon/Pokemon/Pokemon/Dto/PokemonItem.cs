using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Newtonsoft.Json;

namespace Pokemon.Dto
{
    public class PokemonItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("weight")]
        public double Weight { get; set; }

        [JsonProperty("abilities")]
        public ObservableCollection<Ability> Abilities { get; set; }

        [JsonProperty("sprites")]
        public Sprites Sprites { get; set; }
    }
}

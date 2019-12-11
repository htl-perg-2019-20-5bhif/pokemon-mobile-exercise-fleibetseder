using Newtonsoft.Json;
using Pokemon.Dto;
using Pokemon;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Pokemon
{

    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<PokemonItem> Pokemons { get; set; } = new ObservableCollection<PokemonItem>();
        HttpClient HttpClient = new HttpClient();

        public MainPage()
        {
            getPokemonList();
            InitializeComponent();
            //for DataBinding with xaml
            BindingContext = this;
        }
        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new DetailPage(e.SelectedItem));
        }

        async void getPokemonList()
        {
            PokemonUrls pokemon = JsonConvert.DeserializeObject<PokemonUrls>(await HttpClient.GetStringAsync("https://pokeapi.co/api/v2/pokemon"));
            foreach (PokemonUrl pokemonUrl in pokemon.urls)
            {
                Pokemons.Add(JsonConvert.DeserializeObject<PokemonItem>(await HttpClient.GetStringAsync(pokemonUrl.Url)));
            }

        }
    }
}

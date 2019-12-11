using Pokemon.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pokemon
{
    [DesignTimeVisible(false)]
    public partial class DetailsPage : ContentPage
    {

        public PokemonItem Pokemon { get; set; }

        public DetailsPage(object selectedItem)
        {
            Pokemon = (PokemonItem)selectedItem;
            InitializeComponent();
            BindingContext = this;
        }
    }
}
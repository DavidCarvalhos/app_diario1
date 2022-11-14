using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace app_diario.Views
{
    public partial class PaginaLista : ContentPage
    {
        InitializeComponent();
        Shell.SetNavBarHasShadow(this, false);
    }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            CollectionView.ItemSource = await App.GetnotaAsync();
        }
}

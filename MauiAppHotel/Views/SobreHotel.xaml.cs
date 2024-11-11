using System;
using Microsoft.Maui.Controls;

namespace MauiAppHotel.Views
{
    public partial class SobreHotel : ContentPage
    {
        public SobreHotel()
        {
            InitializeComponent();
        }

        private async void OnVoltarClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}

using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XF.ModalNavigation.Views
{
    public partial class ModalPageTwo : ContentPage
    {
        public ModalPageTwo()
        {
            InitializeComponent();
        }

        public async void Close_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync(true);
        }
    }
}

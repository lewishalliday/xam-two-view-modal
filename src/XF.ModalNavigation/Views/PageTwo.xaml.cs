using System;
using Xamarin.Forms;

namespace XF.ModalNavigation.Views
{
    public partial class PageTwo : ContentPage
    {
        public PageTwo()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs args)
        {
            await App.Current.MainPage.Navigation.PushAsync(new PageThree());
        }

        private async void Button2_Clicked(object sender, EventArgs args)
        {
            var page = new ModalPageOne();
            await Navigation.PushModalAsync(new CustomNavigation(page));
        }
    }
}

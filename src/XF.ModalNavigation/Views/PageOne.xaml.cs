using System;
using Xamarin.Forms;

namespace XF.ModalNavigation.Views
{
    public partial class PageOne : ContentPage
    {
        public PageOne()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs args)
		{
            await App.Current.MainPage.Navigation.PushAsync(new PageTwo());
		}
    }
}

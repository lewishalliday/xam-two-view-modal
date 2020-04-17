using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XF.ModalNavigation.Views
{
    public partial class ModalOne : ContentPage
    {
        private int viewShown = 0;

        public ModalOne()
        {
            InitializeComponent();
        }

        private async void Button1_Clicked(object sender, EventArgs args)
        {
            //TODO Show ModalView2

            _ = ModalView1.TranslateTo(this.Width * -1, 0, 300, Easing.Linear);
            _ = ModalView2.TranslateTo(0, 0, 300, Easing.Linear);
        }

        private async void Button2_Clicked(object sender, EventArgs args)
        {
            _ = await App.Current.MainPage.Navigation.PopModalAsync();
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);

            if (viewShown == 0)
            {
                ModalView1.TranslationX = 0;
                ModalView2.TranslationX = width;
            }
            else
            {
                ModalView1.TranslationX = width * -1;
                ModalView2.TranslationX = 0;
            }
        }
    }
}

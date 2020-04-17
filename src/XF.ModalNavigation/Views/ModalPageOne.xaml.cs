using System;
using Xamarin.Forms;

namespace XF.ModalNavigation.Views
{
    public partial class ModalPageOne : ContentPage
    {
        public ModalPageOne()
        {
            InitializeComponent();
        }

        private async void NavToModalView2(object sender, EventArgs args)
        {
            // Slide to view 2
            _ = ModalView1.TranslateTo(this.Width * -1, 0, 300, Easing.Linear);
            _ = ModalView2.TranslateTo(0, 0, 300, Easing.Linear);
        }

        private async void CloseModal(object sender, EventArgs args)
        {
            // Close this page
            _ = await App.Current.MainPage.Navigation.PopModalAsync();
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);

            // Setup where each view is initially placed
            ModalView1.TranslationX = 0;
            ModalView2.TranslationX = width;
        }
    }
}

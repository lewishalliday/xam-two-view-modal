using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.ModalNavigation.Views;

namespace XF.ModalNavigation
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new PageOne());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

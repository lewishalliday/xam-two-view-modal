using System;
using Xamarin.Forms;

namespace XF.ModalNavigation.Views
{
    public partial class ModalViewOne : ContentView
    {
        public ModalViewOne()
        {
            InitializeComponent();
        }

        public event EventHandler GoForwardClicked;

        private void NavToNextView(object sender, EventArgs args)
        {
            GoForwardClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}

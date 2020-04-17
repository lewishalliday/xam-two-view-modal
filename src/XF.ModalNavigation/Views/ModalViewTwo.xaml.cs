using System;
using Xamarin.Forms;

namespace XF.ModalNavigation.Views
{
    public partial class ModalViewTwo : ContentView
    {
        public ModalViewTwo()
        {
            InitializeComponent();
        }

        public event EventHandler CloseModalClicked;

        private void CloseModal(object sender, EventArgs args)
        {
            CloseModalClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}

using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace XF.ModalNavigation.Views
{
    public partial class ModalViewTwo : ModalView
    {
        public ModalViewTwo()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs args)
        {
            RaiseCloseModalClicked();
        }
    }
}

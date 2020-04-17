using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace XF.ModalNavigation.Views
{
    public partial class ModalViewOne : ModalView
    {
        public ModalViewOne()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs args)
        {
            RaiseGoForwardClicked();
        }
    }
}

using System;
using Xamarin.Forms;

namespace XF.ModalNavigation.Views
{
    public abstract class ModalView : ContentView
    {
        public ModalView()
        {
        }

        public event EventHandler GoForwardClicked;
        public event EventHandler GoBackClicked;
        public event EventHandler CloseModalClicked;

        protected void RaiseGoForwardClicked()
        {
            GoForwardClicked?.Invoke(this, EventArgs.Empty);
        }

        protected void RaiseGoBackClicked()
        {
            GoForwardClicked?.Invoke(this, EventArgs.Empty);
        }

        protected void RaiseCloseModalClicked()
        {
            CloseModalClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}

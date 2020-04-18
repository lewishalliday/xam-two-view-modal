using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace XF.ModalNavigation
{
    public class CustomNavigation : Xamarin.Forms.NavigationPage
    {
        public CustomNavigation(Xamarin.Forms.Page root) : base(root)
        {
            On<iOS>().SetModalPresentationStyle(UIModalPresentationStyle.FormSheet);
        }
    }
}

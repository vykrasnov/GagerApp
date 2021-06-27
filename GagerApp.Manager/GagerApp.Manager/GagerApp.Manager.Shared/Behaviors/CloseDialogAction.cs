using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xaml.Interactivity;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
#if NETFX_CORE
using _Popup = Windows.UI.Xaml.Controls.Primitives.Popup;
#else
using _Popup = Windows.UI.Xaml.Controls.Popup;
#endif

namespace GagerApp.Manager.Behaviors
{
    public partial class CloseDialogAction : DependencyObject, IAction
    {
        private static bool CloseDialog()
        {
            var host = GetCurrentPopupHost();
            if (host == null)
            {
                return false;
            }
            var popup = host.Children.OfType<_Popup>().LastOrDefault();
            if (popup != null)
            {
                popup.IsOpen = false;
                return true;
            }
            return false;
        }

        private static Page GetCurrentPage()
        {
            return (Window.Current.Content as Frame).Content as Page;
        }

        private static Panel GetCurrentPopupHost()
        {
            var page = GetCurrentPage();
            if (page == null)
            {
                return null;
            }
            return page.Content as Grid;
        }

        public object Execute(object sender, object parameter)
        {
            CloseDialog();
            return null;
        }
    }
}

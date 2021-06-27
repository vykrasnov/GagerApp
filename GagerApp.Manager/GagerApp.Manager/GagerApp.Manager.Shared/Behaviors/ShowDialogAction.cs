using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xaml.Interactivity;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Markup;
#if NETFX_CORE
using _Popup = Windows.UI.Xaml.Controls.Primitives.Popup;
#else
using _Popup = Windows.UI.Xaml.Controls.Popup;
#endif

namespace GagerApp.Manager.Behaviors
{
    public partial class ShowDialogAction : DependencyObject, IAction
    {
        public string TargetPage
        {
            get => (string)GetValue(TargetPageProperty);
            set => SetValue(TargetPageProperty, value);
        }

        public static readonly DependencyProperty TargetPageProperty =
            DependencyProperty.Register(nameof(TargetPage), typeof(string), typeof(ShowDialogAction), new PropertyMetadata(null, OnTargetPagePropertyChanged));

        private static void OnTargetPagePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
        }

        public object Parameter
        {
            get => (object)GetValue(ParameterProperty);
            set => SetValue(ParameterProperty, value);
        }

        public static readonly DependencyProperty ParameterProperty =
            DependencyProperty.Register(nameof(Parameter), typeof(object), typeof(ShowDialogAction), new PropertyMetadata(null, OnParameterPropertyChanged));

        private static void OnParameterPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
        }

        public object Execute(object sender, object parameter)
        {
            if (string.IsNullOrEmpty(TargetPage))
            {
                return false;   
            }

            ShowPopupPage(parameter);

            return null;
        }

        private void ShowPopupPage(object parameter)
        {
            try
            {
#if HAS_UNO_WASM
                var pageType = Type.GetType(TargetPage);
                var host = GetCurrentPopupHost();
                var popupPage = Activator.CreateInstance(pageType) as Page;
                var popup = new _Popup();
                popup.Child = popupPage;
                if (host != null)
                {
                    host.Children.Add(popup);
                    popup.Opened += (o, e) => (popupPage as Pages.BasePage)?.CreateDataContext(Parameter ?? parameter);
                    popup.Closed += (o, e) => host.Children.Remove(popup);
                }
#else
                IXamlMetadataProvider metadataProvider = Application.Current as IXamlMetadataProvider;
                if (metadataProvider == null)
                {
                    // This will happen if there are no XAML files in the project other than App.xaml.
                    // The markup compiler doesn't bother implementing IXamlMetadataProvider on the app
                    // in that case.
                    return;
                }
                IXamlType xamlType = metadataProvider.GetXamlType(TargetPage);
                if (xamlType == null)
                {
                    return;
                }
                var pageType = xamlType.UnderlyingType;
                var host = GetCurrentPopupHost();
                var popup = new _Popup();
                var popupFrame = new Frame();
                popup.Child = popupFrame;
                if (host != null)
                {
                    host.Children.Add(popup);
                    popup.Opened += (o, e) => popupFrame.Navigate(pageType, Parameter ?? parameter);
                    popup.Closed += (o, e) => host.Children.Remove(popup);
                }
#endif
                var page = GetCurrentPage();
                if (page != null)
                {
                    var handler = new EventHandler<object>((o, e) => UpdateDialogSize(popup));
                    page.LayoutUpdated += handler;
                    popup.Closed += (o, e) => page.LayoutUpdated -= handler;
                }

                popup.IsOpen = true;
            }
            catch (Exception e)
            {
                ShowErrorDialog(e);
            }
        }

        private static async void ShowErrorDialog(Exception e)
        {
            ContentDialog dialog = new ContentDialog()
            {
                Content = e.Message,
                CloseButtonText = "OK"
            };
            await dialog.ShowAsync();
        }

        public void UpdateDialogSize(_Popup popup)
        {
            var root = ((Window.Current.Content as Frame).Content as Page).Content as FrameworkElement;
            (popup.Child as FrameworkElement).Width = root.ActualWidth;
            (popup.Child as FrameworkElement).Height = root.ActualHeight;
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

    }
}

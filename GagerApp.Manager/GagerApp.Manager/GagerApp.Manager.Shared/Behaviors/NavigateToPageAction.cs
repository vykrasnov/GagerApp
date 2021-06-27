using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xaml.Interactivity;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Markup;

namespace GagerApp.Manager.Behaviors
{
    public partial class NavigateToPageAction : DependencyObject, IAction
    {
        public object Execute(object sender, object parameter)
        {
            if (NavFrame == null)
            {
                return null;
            }

            try
            {
#if HAS_UNO_WASM
                var pageType = Type.GetType(TargetPage);
#else
                IXamlMetadataProvider metadataProvider = Application.Current as IXamlMetadataProvider;
                if (metadataProvider == null)
                {
                    // This will happen if there are no XAML files in the project other than App.xaml.
                    // The markup compiler doesn't bother implementing IXamlMetadataProvider on the app
                    // in that case.
                    return null;
                }
                IXamlType xamlType = metadataProvider.GetXamlType(TargetPage);
                if (xamlType == null)
                {
                    return null;
                }
                var pageType = xamlType.UnderlyingType;
#endif

                NavFrame.Navigate(pageType, Parameter ?? parameter);

            }
            catch (Exception e)
            {
                ShowErrorDialog(e);
            }
            return null;
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

        public Frame NavFrame
        {
            get => (Frame)GetValue(NavFrameProperty);
            set => SetValue(NavFrameProperty, value);
        }

        public static readonly DependencyProperty NavFrameProperty =
            DependencyProperty.Register(nameof(NavFrame), typeof(Frame), typeof(NavigateToPageAction), new PropertyMetadata(null, OnNavFramePropertyChanged));

        private static void OnNavFramePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
        }

        public string TargetPage
        {
            get => (string)GetValue(TargetPageProperty);
            set => SetValue(TargetPageProperty, value);
        }

        public static readonly DependencyProperty TargetPageProperty =
            DependencyProperty.Register(nameof(TargetPage), typeof(string), typeof(NavigateToPageAction), new PropertyMetadata(null, OnTargetPagePropertyChanged));

        private static void OnTargetPagePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
        }

        public object Parameter
        {
            get => (object)GetValue(ParameterProperty);
            set => SetValue(ParameterProperty, value);
        }

        public static readonly DependencyProperty ParameterProperty =
            DependencyProperty.Register(nameof(Parameter), typeof(object), typeof(NavigateToPageAction), new PropertyMetadata(null, OnParameterPropertyChanged));

        private static void OnParameterPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
        }

    }
}

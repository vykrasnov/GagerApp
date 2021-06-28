using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace GagerApp.Manager.Pages
{
    public sealed partial class CalculatePage : Page
    {
        public CalculatePage()
        {
            InitializeComponent();
            Loaded += CalculatePage_Loaded;
        }

        private void CalculatePage_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = new Dummy.DummyCalculatePageViewModel();
        }
    }
}

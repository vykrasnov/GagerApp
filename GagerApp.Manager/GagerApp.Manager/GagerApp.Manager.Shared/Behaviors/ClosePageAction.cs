using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xaml.Interactivity;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace GagerApp.Manager.Behaviors
{
    public partial class ClosePageAction : DependencyObject, IAction
    {
        public ClosePageAction()
        {
        }

        public object Execute(object sender, object parameter)
        {
            NavFrame?.GoBack();
            return null;
        }

        public Frame NavFrame
        {
            get => (Frame)GetValue(NavFrameProperty);
            set => SetValue(NavFrameProperty, value);
        }

        public static readonly DependencyProperty NavFrameProperty =
            DependencyProperty.Register(nameof(NavFrame), typeof(Frame), typeof(ClosePageAction), new PropertyMetadata(null, OnNavFramePropertyChanged));

        private static void OnNavFramePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var behavior = d as ClosePageAction;
            behavior?.OnNavFrameChanged();
        }

        private void OnNavFrameChanged()
        {
        }
    }
}

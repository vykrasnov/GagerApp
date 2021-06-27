using System;
using System.Collections.Generic;
using System.Text;
using GagerApp.Manager.Dummy;
using GagerApp.Manager.Pages;
using Microsoft.UI.Xaml.Controls;
using Microsoft.Xaml.Interactivity;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace GagerApp.Manager.Behaviors
{
    internal class NavigationBehavior: Behavior
    {

        public Microsoft.UI.Xaml.Controls.NavigationView NavView
        {
            get => (Microsoft.UI.Xaml.Controls.NavigationView)GetValue(NavViewProperty);
            set => SetValue(NavViewProperty, value);
        }

        public static readonly DependencyProperty NavViewProperty =
            DependencyProperty.Register(nameof(NavView), typeof(Microsoft.UI.Xaml.Controls.NavigationView), typeof(NavigationBehavior), new PropertyMetadata(null, OnNavViewPropertyChanged));

        private static void OnNavViewPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var behavior = d as NavigationBehavior;
            behavior?.OnNavViewChanged(e.OldValue as Microsoft.UI.Xaml.Controls.NavigationView, e.NewValue as Microsoft.UI.Xaml.Controls.NavigationView);
        }

        private void OnNavViewChanged(Microsoft.UI.Xaml.Controls.NavigationView oldValue, Microsoft.UI.Xaml.Controls.NavigationView newValue)
        {
            if (oldValue != null)
            {
                oldValue.SelectionChanged -= NavView_SelectionChanged;
            }
            if (newValue != null)
            {
                newValue.SelectionChanged += NavView_SelectionChanged;
            }
        }

        private void NavView_SelectionChanged(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewSelectionChangedEventArgs args)
        {

            if (NavFrame == null)
            {
                return;
            }
            
            if (args.IsSettingsSelected)
            {

            }
          
            else
            {
                /*
                Microsoft.UI.Xaml.Controls.NavigationViewItem item = args.SelectedItem as Microsoft.UI.Xaml.Controls.NavigationViewItem;
                switch (item.Tag.ToString())
                {
                    case "MyDayPage":
                        NavFrame.Navigate(typeof(MyDayPage), new NavParams()
                        {
                            VMP = null,
                            VMT = typeof(DummyMyDayPageViewModel).FullName
                        }
                        );
                        break;
                   
                    case "MaterialValues":
                        NavFrame.Navigate(typeof(MaterialValues), new NavParams()
                        {
                            VMP = null,
                            VMT = typeof(DummyMaterialValuesViewModel).FullName
                        }
                        );
                        break;
                    case "MonetaryResource":
                        NavFrame.Navigate(typeof(MonetaryResourcePage), new NavParams()
                        {
                            VMP = null,
                            VMT = typeof(DummyMonetaryResourceViewPageModel).FullName
                        }
                        );
                        break;
                    case "OrdersPage":
                        NavFrame.Navigate(typeof(OrderPage), new NavParams()
                        {
                            VMP = null,
                            VMT = typeof(DummyOrderPageViewModel).FullName
                        }
                        );
                        break;
                    case "PartnerPage":
                        NavFrame.Navigate(typeof(PartnerPage), new NavParams()
                        {
                            VMP = null,
                            VMT = typeof(DummyPartnerPageViewModel).FullName
                        }
                        );
                        break;
                    case "Worker":
                        NavFrame.Navigate(typeof(WorkerPage), new NavParams()
                        {
                            VMP = null,
                            VMT = typeof(DummyWorkerPageVIewModel).FullName
                        }
                        );
                        break;
                    default:
                        throw new NotImplementedException($"The Tag {item.Tag.ToString()} is not supported");
                }
                */
            }

        }

        public Frame NavFrame
        {
            get => (Frame)GetValue(NavFrameProperty);
            set => SetValue(NavFrameProperty, value);
        }

        public static readonly DependencyProperty NavFrameProperty =
            DependencyProperty.Register("NavFrame", typeof(Frame), typeof(NavigationBehavior), new PropertyMetadata(null, OnNavFramePropertyChanged));

        private static void OnNavFramePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var behavior = d as NavigationBehavior;
            behavior?.OnNavFrameChanged();
        }

        private void OnNavFrameChanged()
        {
        }

        protected override void OnAttached()
        {
            base.OnAttached();
        }

        protected override void OnDetaching()
        {
            base.OnDetaching();
        }
    }
}

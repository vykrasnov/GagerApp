using System;
using System.Collections.Generic;
using System.Text;
using Calcium;
using Calcium.Navigation;
using GagerApp.Core;
using GagerApp.Core.Services;
using GagerApp.Manager.Pages;
using GagerApp.Manager.Services;
using Windows.UI.Xaml.Controls;

namespace GagerApp.Manager
{
    public static partial class Bootstrapper
    {
        private static bool Initialized = false;

        internal static void Init()
        {
            if (Initialized)
            {
                return;
            }

            Initialized = true;
#if WASM
            //Dependency.Register<Calcium.Services.INavigationService, NavigationService>(singleton:true);
#endif
            // Dependency.Register<Core.Services.IDialogService, DialogService>();
            Dependency.Register<ILoginService, DummyLoginService>();
            //Dependency.Register<IUserService, UserService>();
            //Dependency.Register<IOrderService, OrdersService>();
            //  Dependency.Register<IOrderPageService, OrderPageService>();
            //  Dependency.Register<IPlatformService, PlatformService>();
            //  Dependency.Register<IRoomService, RoomService>();
            //  Dependency.Register<IRoomPageService, DummyRoomPageService>();
            //  // Dependency.Register<IDopUslugaService, DopUslugaService>();
            //  Dependency.Register<IDiscountService, DiscountService>();

            //конфигурация навигации
            Dependency.Register<IRoutingService, CustomRoutingService>(singleton: true);
        }

        private class CustomRoutingService : RoutingService
        {
            private static readonly Dictionary<Type, Type> PagesDictionary = new Dictionary<Type, Type>()
            {
            };

            #region Methods/Events

            public static void LaunchPage(Type viewModelType, object param = null, bool noHistory = false)
            {
                if (PagesDictionary.TryGetValue(viewModelType, out var pageType))
                {
                    var window = Windows.UI.Xaml.Window.Current;
                    Frame rootFrame = window.Content as Frame;

                    var navigationParameter = new NavParams() { VMT = viewModelType.FullName, VMP = param };

                    rootFrame.Navigate(pageType, navigationParameter);
                }
            }

            public override void Navigate(string relativeUrl, object navigationArgument = null)
            {
                Type type = NavigationDictionary.ResolveType(relativeUrl);
                RegisterPath(relativeUrl, (obj) => LaunchPage(type, navigationArgument));
                base.Navigate(relativeUrl, navigationArgument);
            }

            #endregion Methods/Events
        }
    }
}

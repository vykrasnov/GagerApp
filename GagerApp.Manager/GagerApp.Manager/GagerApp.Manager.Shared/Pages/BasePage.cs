using System;
using System.Collections.Generic;
using System.Text;
using Calcium;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace GagerApp.Manager.Pages
{
    public class BasePage : Page
    {
        public BasePage()
        {
            Loaded += BasePage_Loaded;
        }

        private void BasePage_Loaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            if (DataContext == null)
            {
                DataContext = new Dummy.DummyViewModel();
            }
            
        }

#if HAS_UNO_WASM

        /// <summary>
        /// A backdoor for the WASM part. Needed to pass the parameter and emulate OnNavigatedTo when the page is present as dialog
        /// </summary>
        /// <param name="param"></param>
        public void CreateDataContext(object param)
        {
            CreateDataContext(param as NavParams);
        }
#endif

        protected sealed override void OnNavigatedTo(NavigationEventArgs e)
        {
            Bootstrapper.Init();

            var parameter = e.Parameter as NavParams;

            CreateDataContext(parameter);
        }

        private void CreateDataContext(NavParams parameter)
        {
            if (parameter == null)
            {
                //This shouldn't happen!!!
                throw new ArgumentException("Navigation parameter of unsupported type.");
            }

            if (parameter.VMP != null)
            {
                Dependency.Register(parameter.VMP.GetType(), parameter.VMP);
            }

            DataContext = Dependency.ResolveWithType(parameter.ViewModelType);
        }

        public class NavigationParams
        {
            public NavigationParams(Type viewModelType, object viewModelParameter)
            {
                ViewModelType = viewModelType ?? throw new ArgumentNullException(nameof(viewModelType));
                ViewModelParameter = viewModelParameter;
            }

            public Type ViewModelType
            {
                get;
            }
            public object ViewModelParameter
            {
                get;
            }
        }
    }
}

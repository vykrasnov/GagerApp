using System;
using System.Collections.Generic;
using System.Text;

namespace GagerApp.Manager.Pages
{
    public class NavParams
    {
        private string _viewModelTypeName;

        public NavParams()
        {
        }

        public Type ViewModelType
        {
            get;
            private set;
        }


        public string VMT
        {
            get => _viewModelTypeName;
            set
            {
                _viewModelTypeName = value;
                ViewModelType = Type.GetType(_viewModelTypeName);
            }
        }

        public object VMP
        {
            get;
            set;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using GagerApp.Model.Entities;
using Windows.UI.Xaml.Data;

namespace GagerApp.Manager.Converters
{
    internal class OrderStatusToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value == null)
            {
                return string.Empty;
            }

            OrderStatus orderStatus = (OrderStatus)value;
            return orderStatus.Translate();
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotSupportedException();
        }
    }
}

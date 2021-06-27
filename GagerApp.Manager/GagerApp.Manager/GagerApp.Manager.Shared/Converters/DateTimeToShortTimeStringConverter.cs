using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Xaml.Data;

namespace GagerApp.Manager.Converters
{
    public class DateTimeToShortTimeStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            DateTime dateTime = (DateTime)value;
            return dateTime.ToString("hh:mm");
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotSupportedException();
        }
    }
}

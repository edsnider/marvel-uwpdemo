using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace MarvelDemo.Common
{
    class BoolToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (!(value is bool))
                return Visibility.Collapsed;
            
            if (parameter is string && ((string)parameter)[0] == '!')
                return (bool)value ? Visibility.Collapsed : Visibility.Visible;
            
            return (bool)value ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}

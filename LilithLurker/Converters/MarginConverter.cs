using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using LilithLurker.Models;

namespace LilithLurker.Converters
{
    internal class MarginConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Position position)
            {
                return new Thickness(position.Left, position.Top, 0, 0);
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}

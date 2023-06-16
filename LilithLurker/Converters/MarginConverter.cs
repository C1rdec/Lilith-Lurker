using System;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Data;
using LilithLurker.Models;

namespace LilithLurker.Converters
{
    internal class MarginConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var window = Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
            var source = PresentationSource.FromVisual(window);

            var scaleX = source.CompositionTarget.TransformToDevice.M11;
            var scaleY = source.CompositionTarget.TransformToDevice.M22;
            if (value is Position position)
            {
                return new Thickness(position.Left / scaleX, position.Top / scaleY, 0, 0);
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}

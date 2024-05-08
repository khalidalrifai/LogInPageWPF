/* NOT USED CURRENTLY */

using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace LogInPageWPF.Converters
{
    public class InvertedBooleanToVisibilityConverter : IValueConverter
    {
        // The conversion of the boolean value to a Visibility value, inverting the usual boolean logic.
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Checking if the input value is a boolean
            if (value is bool boolValue)
            {
                // Returning Collapsed if true, otherwise Visible
                return boolValue ? Visibility.Collapsed : Visibility.Visible;
            }
            // Default to Visible if the value isn't a boolean
            return Visibility.Visible;
        }

        // ConvertBack is not implemented because the conversion from Visibility to Boolean is not straightforward.
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException("Converting from Visibility to Boolean is not supported.");
        }
    }
}

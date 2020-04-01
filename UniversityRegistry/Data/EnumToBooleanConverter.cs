using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Data;

namespace UniversityRegistry.Data
{
    /// <summary>
    /// A class for converting enum values to booleans for use in data binding.
    /// </summary>
    public class EnumToBooleanConverter : IValueConverter
    {
        /// <summary>
        /// Converts an enum value into a boolean by comparing it to the supplied parameter.
        /// Fi the value and parameter are the same, the method returns true; otherwise false.
        /// </summary>
        /// <param name="value">The enum value to convert</param>
        /// <param name="targetType">The type to convert to (should be a boolean)</param>
        /// <param name="parameter">The enum value to compare to</param>
        /// <param name="culture">The culture info</param>
        /// <returns>True, if the enum matches the param, false otherwise.</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value.Equals(parameter);
        }

        /// <summary>
        /// Converts a boolean into an enum value. If the boolean is true, the parameter is returned,
        /// otherwise DependencyProperty, UnsetValue is returned (which unsets the control)
        /// </summary>
        /// <param name="value">The boolean to convert</param>
        /// <param name="targetType">The type to convert(should be an enum)</param>
        /// <param name="parameter">The enumeration value to check</param>
        /// <param name="culture">The culture info</param>
        /// <returns></returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((bool)value) return parameter;
            else return DependencyProperty.UnsetValue;
        }
    }
}

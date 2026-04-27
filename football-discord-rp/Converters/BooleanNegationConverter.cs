using System.Globalization;
using System.Windows.Data;

namespace football_discord_rp.Converters
{
    public class BooleanNegationConverter : IValueConverter
    {
        /// <inheritdoc />
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is bool boolVal)
            {
                return !boolVal;
            }

            throw new InvalidOperationException("Converter only works with values of type bool!");
        }

        /// <inheritdoc />
        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is bool boolVal)
            {
                return !boolVal;
            }

            throw new InvalidOperationException("Converter only works with values of type bool!");
        }
    }
}

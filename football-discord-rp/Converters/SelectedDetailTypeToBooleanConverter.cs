using System.Globalization;
using System.Windows.Data;

namespace football_discord_rp.Converters
{
    public class SelectedDetailTypeToBooleanConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is not SelectedDetailType selectedTypeValue || parameter is not SelectedDetailType selectedTypeParameter)
            {
                throw new InvalidOperationException("value and parameter must be of type SelectedDetailType");
            }

            return selectedTypeValue.Equals(selectedTypeParameter);
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            return value?.Equals(true) == true ? parameter : Binding.DoNothing;
        }
    }
}

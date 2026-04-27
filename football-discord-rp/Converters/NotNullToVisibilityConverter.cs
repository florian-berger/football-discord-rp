using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace football_discord_rp.Converters
{
    public class NotNullToVisibilityConverter : IValueConverter
    {
        public bool Inverse { get; set; } = false;

        public bool HiddenInsteadOfCollapsed { get; set; } = false;

        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (Inverse)
            {
                return value != null 
                    ? (HiddenInsteadOfCollapsed ? Visibility.Hidden : Visibility.Collapsed)
                    : Visibility.Visible;
            }

            return value != null 
                ? Visibility.Visible
                : (HiddenInsteadOfCollapsed ? Visibility.Hidden : Visibility.Collapsed);
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

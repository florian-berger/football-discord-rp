using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace football_discord_rp.Helper
{
    public static class WebImageHelper
    {
        public static ImageSource GetImageSourceFromPath(string imagePath)
        {
            var bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri(imagePath, UriKind.Absolute);
            bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
            bitmapImage.EndInit();

            try
            {
                bitmapImage.Freeze();
            }
            catch (InvalidOperationException)
            {
                // Image is animated or otherwise cannot be frozen — return it as-is.
            }

            return bitmapImage;
        }
    }
}

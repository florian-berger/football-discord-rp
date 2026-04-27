using ModernWpf.Controls;

namespace football_discord_rp
{
    /// <summary>
    ///     Collection of static commands that are available within the whole solution
    /// </summary>
    public static class StaticCommands
    {
        #region Commands

        /// <summary>
        ///     Command to open a URI, passed as parameter
        /// </summary>
        public static DelegateCommand<string> OpenUriCommand => field ??= new DelegateCommand<string>(OpenUri);
        
        /// <summary>
        ///     Command to display an Info about dialog to the user
        /// </summary>
        public static AsyncDelegateCommand ShowAboutCommand => field ??= new AsyncDelegateCommand(ShowAbout);

        /// <summary>
        ///     Command to display a "Not implemented" dialog
        /// </summary>
        public static AsyncDelegateCommand ShowNotImplementedCommand => field ??= new AsyncDelegateCommand(ShowNotImplementedDialog);

        #endregion Commands

        #region Private methods

        private static void OpenUri(string uri)
        {
            if (string.IsNullOrWhiteSpace(uri)) throw new ArgumentException("URI cannot be null or empty.", nameof(uri));

            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = uri,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                throw new InvalidOperationException("Failed to open the specified URI.", ex);
            }
        }

        private static async Task ShowAbout()
        {
            var dlg = new ContentDialog
            {
                Title = "About Football Discord RP",
                Content = "" +
                          $"Version: {FootballDiscordRp.AppName}\n" +
                          $"Repository: {FootballDiscordRp.RepositoryUrl}\n\n" +
                          "This application is open-source and licensed under the MIT License.",
                CloseButtonText = "Close",
                PrimaryButtonText = "Open repository",
                DefaultButton = ContentDialogButton.Close
            };
            
            var result = await dlg.ShowAsync(ContentDialogPlacement.InPlace);
            if (result == ContentDialogResult.Primary)
            {
                OpenUri(FootballDiscordRp.RepositoryUrl);
            }
        }

        private static async Task ShowNotImplementedDialog()
        {
            var dialog = new ContentDialog
            {
                Title = "Not implemented",
                Content = "The requested method is not implemented yet. Please check back later.",
                PrimaryButtonText = "Ok",
                DefaultButton = ContentDialogButton.Primary
            };

            await dialog.ShowAsync();
        }

        #endregion Private methods
    }
}

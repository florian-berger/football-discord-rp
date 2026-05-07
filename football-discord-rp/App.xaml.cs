using System.Windows;

namespace football_discord_rp
{
    /// <summary>
    ///     Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        private void App_OnStartup(object sender, StartupEventArgs e)
        {
#if DEBUG
            FootballDiscordRp.SkipUpdateNotification = true;
#else
            FootballDiscordRp.SkipUpdateNotification = e.Args.Contains("--skip-update-notification");
#endif
        }
    }
}

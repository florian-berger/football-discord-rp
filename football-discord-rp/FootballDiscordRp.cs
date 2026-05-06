using System.Reflection;

namespace football_discord_rp
{
    /// <summary>
    ///     Class having some static members to be used across the project.
    /// </summary>
    public static class FootballDiscordRp
    {
        #region Constants

        public const string DiscordApplicationId = "1498398924166135888";
        public const string AppName = "Football DiscordRP";
        public const string RepositoryUrl = "https://github.com/florian-berger/football-discord-rp";
        public const string UpdateCheckApiUrl = "https://api.github.com/repos/florian-berger/football-discord-rp/releases/latest";

        #endregion Constants

        #region Public properties

        public static string WindowTitle = $"{AppName} {Assembly.GetExecutingAssembly().GetName().Version?.ToShortString() ?? "DEV"}";

        public static AppSettings Settings => field ??= AppSettings.Load();

        #endregion Public properties
    }
}

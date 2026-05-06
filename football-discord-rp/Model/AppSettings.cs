namespace football_discord_rp.Model
{
    /// <summary>
    ///     Settings for the application that should be hold over multiple sessions
    /// </summary>
    public class AppSettings
    {
        #region Properties
        
        /// <summary>
        ///     Detail type that was selected the last time
        /// </summary>
        public SelectedDetailType DetailType { get; set; }
        
        /// <summary>
        ///     League that was selected the last time
        /// </summary>
        public string? SelectedLeague { get; set; }

        /// <summary>
        ///     Information if the dark mode should be used. NULL for using system settings
        /// </summary>
        public bool UseDarkMode { get; set; } = true;
        
        /// <summary>
        ///     Last used custom detail
        /// </summary>
        public string? CustomDetail { get; set; }

        #endregion Properties

        #region Public methods
        
        /// <summary>
        ///     Loads the current settings from file. If the file does not
        ///     exist, it will be created with the default settings
        /// </summary>
        public static AppSettings Load()
        {
            return SettingsHelper<AppSettings>.LoadSettings();
        }

        /// <summary>
        ///     Saves the current settings to a file
        /// </summary>
        public void Save()
        {
            SettingsHelper<AppSettings>.SaveSettings(this);
        }

        #endregion Public methods
    }
}

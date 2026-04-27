namespace football_discord_rp.Model
{
    /// <summary>
    ///     Represents a football league, like the Bundesliga
    /// </summary>
    public class League
    {
        /// <summary>
        ///     Name of the league
        /// </summary>
        public required string Name { get; set; }

        /// <summary>
        ///     List of the clubs part of this league
        /// </summary>
        public required IReadOnlyCollection<Club> Clubs { get; set; }
        
        /// <summary>
        ///     Season that is currently being played, e.g. "2025/26"
        /// </summary>
        public required string Season { get; set; }
        
        /// <summary>
        ///     Key of the image for this league, configured in the Discord Developer Portal
        /// </summary>
        public string? ImageKey { get; set; }

        /// <summary>
        ///     Name for displaying in the UI, combining the league name and the season, e.g. "Bundesliga (2025/26)"
        /// </summary>
        public string DisplayName => $"{Name} ({Season})";
    }
}

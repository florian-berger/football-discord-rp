using football_discord_rp.Data;

namespace football_discord_rp
{
    /// <summary>
    ///     Store of the application data, such as the list of leagues, clubs, and so on
    /// </summary>
    public static class DataStore
    {
        /// <summary>
        ///     List of all available leagues
        /// </summary>
        public static List<League> AppLeagues { get; set; } =
        [
            Leagues.Ger1,
            Leagues.Ger2,
            Leagues.Ger3,
            Leagues.FifaWorldCup
        ];
    }
}

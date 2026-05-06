namespace football_discord_rp.Data.Model
{
    /// <summary>
    ///     Class representing a football club
    /// </summary>
    public class Club
    {
        /// <summary>
        ///     Full name of the club
        /// </summary>
        public required string FullName { get; set; }

        /// <summary>
        ///     Abbreviation of the club, like "BVB" for Borussia Dortmund
        /// </summary>
        public required string ShortName { get; set; }
    }
}

namespace football_discord_rp.Model
{
    /// <summary>
    ///     Detail type for the rich presence
    /// </summary>
    public enum SelectedDetailType
    {
        /// <summary>
        ///     User is watching the conference
        /// </summary>
        DetailTypeConference,
        /// <summary>
        ///     User is watching a single match
        /// </summary>
        DetailTypeMatchup,
        /// <summary>
        ///     Custom defined text
        /// </summary>
        DetailTypeCustom,
        /// <summary>
        ///     No details
        /// </summary>
        DetailTypeNone
    }
}

namespace football_discord_rp.Extensions
{
    /// <summary>
    ///     Provides extension methods for working with version numbers
    /// </summary>
    public static class VersionExtension
    {
        /// <summary>
        ///     Converts the specified <see cref="Version"/> object to its short string representation.
        /// </summary>
        /// <param name="version">
        ///     The <see cref="Version"/> object to convert.
        /// </param>
        /// <param name="includeRevisionIfSet">
        ///     Set to true if the revision should be added
        /// </param>
        /// <returns>
        ///     A string representation of the version, including only non-negative and significant components,
        ///     with trailing zero components omitted.
        /// </returns>
        public static string ToShortString(this Version version, bool includeRevisionIfSet = false)
        {
            var versionStr = $"{version.Major}.{version.Minor}";
            if (version.Build > 0)
            {
                versionStr += $".{version.Build}";
            }

            if (includeRevisionIfSet && version.Revision > 0)
            {
                versionStr += $" Rev. {version.Revision}";
            }

            return versionStr;
        }
    }
}

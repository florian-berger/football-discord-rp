using System.Net.Http;
using System.Text.Json;

namespace football_discord_rp.Helper
{
    internal static class VersionHelper
    {
        internal static async Task<(Version Version, string ReleaseLink)?> CheckForUpdate(Version currentVersion)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", $"Football-Discord-RP/{currentVersion.ToShortString()}");

            // Read the latest release information from GitHub and parse the JSON
            var response = await client.GetStringAsync(FootballDiscordRp.UpdateCheckApiUrl);
            var json = JsonDocument.Parse(response);

            // Search the tag name and trim the leading 'v' (tag will always be named in the format vX.Y.Z)
            var versionString = json.RootElement.GetProperty("tag_name").GetString() ?? string.Empty;
            var newestVersion = Version.Parse(versionString.TrimStart('v'));
            var releaseLink = json.RootElement.GetProperty("html_url").GetString() ?? string.Empty;

            return newestVersion > currentVersion ? new ValueTuple<Version, string>(newestVersion, releaseLink) : null;
        }
    }
}

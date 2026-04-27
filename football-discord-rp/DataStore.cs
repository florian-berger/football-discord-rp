namespace football_discord_rp
{
    /// <summary>
    ///     Store of the application data, such as the list of leagues, clubs, and so on
    /// </summary>
    public static class DataStore
    {
        /// <summary>
        ///     Representing the first German division
        /// </summary>
        private static readonly League LeagueGer1 = new()
        {
            Name = "Bundesliga",
            Season = "2025/26",
            ImageKey = "de_1",
            Clubs = new List<Club>
            {
                new()
                {
                    FullName = "Bayern München",
                    ShortName = "FCB"
                },
                new()
                {
                    FullName = "Bayer Leverkusen",
                    ShortName = "B04"
                },
                new()
                {
                    FullName = "Eintracht Frankfurt",
                    ShortName = "SGE"
                },
                new()
                {
                    FullName = "Borussia Dortmund",
                    ShortName = "BVB"
                },
                new()
                {
                    FullName = "SC Freiburg",
                    ShortName = "SCF"
                },
                new()
                {
                    FullName = "Mainz 05",
                    ShortName = "M05"
                },
                new()
                {
                    FullName = "RB Leipzig",
                    ShortName = "RBL"
                },
                new()
                {
                    FullName = "Werder Bremen",
                    ShortName = "SVW"
                },
                new()
                {
                    FullName = "VfB Stuttgart",
                    ShortName = "VFB"
                },
                new()
                {
                    FullName = "Borussia Mönchengladbach",
                    ShortName = "BMG"
                },
                new()
                {
                    FullName = "VfL Wolfsburg",
                    ShortName = "WOB"
                },
                new()
                {
                    FullName = "FC Augsburg",
                    ShortName = "FCA"
                },
                new()
                {
                    FullName = "Union Berlin",
                    ShortName = "FCU"
                },
                new()
                {
                    FullName = "FC St. Pauli",
                    ShortName = "STP"
                },
                new()
                {
                    FullName = "TSG Hoffenheim",
                    ShortName = "TSG"
                },
                new()
                {
                    FullName = "FC Heidenheim",
                    ShortName = "FCH"
                },
                new()
                {
                    FullName = "1. FC Köln",
                    ShortName = "KOE"
                },
                new()
                {
                    FullName = "Hamburger SV",
                    ShortName = "HSV"
                }
            }
        };

        /// <summary>
        ///     Representing the second German division
        /// </summary>
        private static readonly League LeagueGer2 = new()
        {
            Name = "2. Bundesliga",
            Season = "2025/26",
            ImageKey = "de_2",
            Clubs = new List<Club>
            {
                new()
                {
                    FullName = "Holstein Kiel",
                    ShortName = "KSV"
                },
                new()
                {
                    FullName = "VfL Bochum",
                    ShortName = "BOC"
                },
                new()
                {
                    FullName = "SV Elversberg",
                    ShortName = "ELV"
                },
                new()
                {
                    FullName = "SC Paderborn",
                    ShortName = "SCP"
                },
                new()
                {
                    FullName = "FC Magdeburg",
                    ShortName = "FCM"
                },
                new()
                {
                    FullName = "Fortuna Düsseldorf",
                    ShortName = "F95"
                },
                new()
                {
                    FullName = "FC Kaiserslautern",
                    ShortName = "FCK"
                },
                new()
                {
                    FullName = "Karlsruher SC",
                    ShortName = "KSC"
                },
                new()
                {
                    FullName = "Hannover 96",
                    ShortName = "H96"
                },
                new()
                {
                    FullName = "1. FC Nürnberg",
                    ShortName = "FCN"
                },
                new()
                {
                    FullName = "Hertha BSC",
                    ShortName = "BSC"
                },
                new()
                {
                    FullName = "Darmstadt 98",
                    ShortName = "SVD"
                },
                new()
                {
                    FullName = "Greuther Fürth",
                    ShortName = "SGF"
                },
                new()
                {
                    FullName = "Schalke 04",
                    ShortName = "S04"
                },
                new()
                {
                    FullName = "Preußen Münster",
                    ShortName = "PRM"
                },
                new()
                {
                    FullName = "Eintracht Braunschweig",
                    ShortName = "EBS"
                },
                new()
                {
                    FullName = "Arminia Bielefeld",
                    ShortName = "DSC"
                },
                new()
                {
                    FullName = "Dynamo Dresden",
                    ShortName = "SGD"
                },
            }
        };

        /// <summary>
        ///     List of all available leagues
        /// </summary>
        public static List<League> Leagues { get; set; } =
        [
            LeagueGer1,
            LeagueGer2
        ];
    }
}

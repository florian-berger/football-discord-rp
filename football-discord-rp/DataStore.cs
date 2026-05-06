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
            Id = "DEU_1",
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
            Id = "DEU_2",
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
        ///     Representing the third German division
        /// </summary>
        private static readonly League LeagueGer3 = new()
        {
            Id = "DEU_3",
            Name = "3. Liga",
            Season = "2025/26",
            Clubs = new List<Club>
            {
                new()
                {
                    FullName = "VfL Osnabrück",
                    ShortName = "OSN"
                },
                new()
                {
                    FullName = "Energie Cottbus",
                    ShortName = "ENE"
                },
                new()
                {
                    FullName = "Rot-Weiss Essen",
                    ShortName = "RWE"
                },
                new()
                {
                    FullName = "MSV Duisburg",
                    ShortName = "DUI"
                },
                new()
                {
                    FullName = "Hansa Rostock",
                    ShortName = "FCH"
                },
                new()
                {
                    FullName = "SC Verl",
                    ShortName = "SCV"
                },
                new()
                {
                    FullName = "Alemannia Aachen",
                    ShortName = "ALE"
                },
                new()
                {
                    FullName = "1860 München",
                    ShortName = "M60"
                },
                new()
                {
                    FullName = "Wehen Wiesbaden",
                    ShortName = "WIE"
                },
                new()
                {
                    FullName = "Waldhof Mannheim",
                    ShortName = "SVW"
                },
                new()
                {
                    FullName = "Viktoria Köln",
                    ShortName = "VIK"
                },
                new()
                {
                    FullName = "Jahn Regensburg",
                    ShortName = "REG"
                },
                new()
                {
                    FullName = "FC Ingolstadt",
                    ShortName = "FCI"
                },
                new()
                {
                    FullName = "VfB Stuttgart II",
                    ShortName = "VFB"
                },
                new()
                {
                    FullName = "1. FC Saarbrücken",
                    ShortName = "FCS"
                },
                new()
                {
                    FullName = "1899 Hoffenheim II",
                    ShortName = "HOF"
                },
                new()
                {
                    FullName = "TSV Havelse",
                    ShortName = "HAV"
                },
                new()
                {
                    FullName = "SSV Ulm",
                    ShortName = "ULM"
                },
                new()
                {
                    FullName = "Erzgebirge Aue",
                    ShortName = "AUE"
                },
                new()
                {
                    FullName = "1. FC Schweinfurt",
                    ShortName = "S05"
                }
            }
        };

        /// <summary>
        ///     Representing the FIFA World Cup
        /// </summary>
        private static readonly League FifaWorldCup = new()
        {
            Id = "INT_WorldCup",
            Name = "FIFA World Cup",
            Season = "2026",
            Clubs = new List<Club>
            {
                new()
                {
                    FullName = "Canada",
                    ShortName = "CAN"
                },
                new()
                {
                    FullName = "Mexico",
                    ShortName = "MEX"
                },
                new()
                {
                    FullName = "USA",
                    ShortName = "USA"
                },
                new()
                {
                    FullName = "Algeria",
                    ShortName = "DZA"
                },
                new()
                {
                    FullName = "Argentina",
                    ShortName = "ARG"
                },
                new()
                {
                    FullName = "Australia",
                    ShortName = "AUS"
                },
                new()
                {
                    FullName = "Austria",
                    ShortName = "AUT"
                },
                new()
                {
                    FullName = "Belgium",
                    ShortName = "BEL"
                },
                new()
                {
                    FullName = "Bosnia-Herzegovina",
                    ShortName = "BIH"
                },
                new()
                {
                    FullName = "Brazil",
                    ShortName = "BRA"
                },
                new()
                {
                    FullName = "Cabo Verde",
                    ShortName = "CPV"
                },
                new()
                {
                    FullName = "Colombia",
                    ShortName = "COL"
                },
                new()
                {
                    FullName = "Congo DR",
                    ShortName = "COD"
                },
                new()
                {
                    FullName = "Côte d'Ivoire",
                    ShortName = "CIV"
                },
                new()
                {
                    FullName = "Croatia",
                    ShortName = "HRV"
                },
                new()
                {
                    FullName = "Curaçao",
                    ShortName = "CUW"
                },
                new()
                {
                    FullName = "Czechia",
                    ShortName = "CZE"
                },
                new()
                {
                    FullName = "Ecuador",
                    ShortName = "ECU"
                },
                new()
                {
                    FullName = "Egypt",
                    ShortName = "EGY"
                },
                new()
                {
                    FullName = "England",
                    ShortName = "ENG"
                },
                new()
                {
                    FullName = "France",
                    ShortName = "FRA"
                },
                new()
                {
                    FullName = "Germany",
                    ShortName = "DEU"
                },
                new()
                {
                    FullName = "Ghana",
                    ShortName = "GHA"
                },
                new()
                {
                    FullName = "Haiti",
                    ShortName = "HTI"
                },
                new()
                {
                    FullName = "IR Iran",
                    ShortName = "IRN"
                },
                new()
                {
                    FullName = "Iraq",
                    ShortName = "IRQ"
                },
                new()
                {
                    FullName = "Japan",
                    ShortName = "JPN"
                },
                new()
                {
                    FullName = "Jordan",
                    ShortName = "JOR"
                },
                new()
                {
                    FullName = "Korea Republic",
                    ShortName = "KOR"
                },
                new()
                {
                    FullName = "Morocco",
                    ShortName = "MAR"
                },
                new()
                {
                    FullName = "Netherlands",
                    ShortName = "NLD"
                },
                new()
                {
                    FullName = "New Zealand",
                    ShortName = "NZL"
                },
                new()
                {
                    FullName = "Norway",
                    ShortName = "NOR"
                },
                new()
                {
                    FullName = "Panama",
                    ShortName = "PAN"
                },
                new()
                {
                    FullName = "Paraguay",
                    ShortName = "PRY"
                },
                new()
                {
                    FullName = "Portugal",
                    ShortName = "PRT"
                },
                new()
                {
                    FullName = "Qatar",
                    ShortName = "QAT"
                },
                new()
                {
                    FullName = "Saudi Arabia",
                    ShortName = "SAU"
                },
                new()
                {
                    FullName = "Scotland",
                    ShortName = "SCO"
                },
                new()
                {
                    FullName = "Senegal",
                    ShortName = "SEN"
                },
                new()
                {
                    FullName = "South Africa",
                    ShortName = "ZAF"
                },
                new()
                {
                    FullName = "Spain",
                    ShortName = "ESP"
                },
                new()
                {
                    FullName = "Sweden",
                    ShortName = "SWE"
                },
                new()
                {
                    FullName = "Switzerland",
                    ShortName = "CHE"
                },
                new()
                {
                    FullName = "Tunisia",
                    ShortName = "TUN"
                },
                new()
                {
                    FullName = "Türkiye",
                    ShortName = "TUR"
                },
                new()
                {
                    FullName = "Uruguay",
                    ShortName = "URY"
                },
                new()
                {
                    FullName = "Uzbekistan",
                    ShortName = "UZB"
                }
            }
        };
        
        /// <summary>
        ///     List of all available leagues
        /// </summary>
        public static List<League> Leagues { get; set; } =
        [
            LeagueGer1,
            LeagueGer2,
            LeagueGer3,
            FifaWorldCup
        ];
    }
}

using football_discord_rp.Data.Clubs;
using football_discord_rp.Data.Model;

namespace football_discord_rp.Data
{
    /// <summary>
    ///     All supported leagues
    /// </summary>
    public static class Leagues
    {
        /// <summary>
        ///     Representing the first German division
        /// </summary>
        public static readonly League Ger1 = new()
        {
            Id = "DEU_1",
            Name = "Bundesliga",
            Season = "2026/27",
            ImageKey = "de_1",
            Clubs =
            [
                Germany.BayernMuenchen,
                Germany.BorussiaDortmund,
                Germany.RbLeipzig,
                Germany.VfbStuttgart,
                Germany.TsgHoffenheim,
                Germany.BayerLeverkusen,
                Germany.ScFreiburg,
                Germany.EintrachtFrankfurt,
                Germany.FcAugsburg,
                Germany.FsvMainz,
                Germany.UnionBerlin,
                Germany.BorussiaMoenchengladbach,
                Germany.HamburgerSv,
                Germany.FcKoeln,
                Germany.WerderBremen,
                Germany.FcSchalke,
                Germany.SvElversberg,
                Germany.ScPaderborn
            ]
        };

        /// <summary>
        ///     Representing the second German division
        /// </summary>
        public static readonly League Ger2 = new()
        {
            Id = "DEU_2",
            Name = "2. Bundesliga",
            Season = "2026/27",
            ImageKey = "de_2",
            Clubs =
            [
                Germany.VflWolfsburg,
                Germany.FcHeidenheim,
                Germany.StPauli,
                Germany.Hannover,
                Germany.SvDarmstadt,
                Germany.FcKaiserslautern,
                Germany.HerthaBsc,
                Germany.FcNuernberg,
                Germany.VflBochum,
                Germany.KarlsruherSc,
                Germany.DynamoDresden,
                Germany.HosteinKiel,
                Germany.ArminiaBielefeld,
                Germany.FcMagdeburg,
                Germany.EintrachtBraunschweig,
                Germany.GreutherFuerth,
                Germany.VflOsnabrueck,
                Germany.EnergieCottbus
            ]
        };

        /// <summary>
        ///     Representing the third German division
        /// </summary>
        public static readonly League Ger3 = new()
        {
            Id = "DEU_3",
            Name = "3. Liga",
            Season = "2026/27",
            ImageKey = "de_3",
            Clubs =
            [
                Germany.FortunaDuesseldorf,
                Germany.PreussenMuenster,
                Germany.RotWeissEssen,
                Germany.MsvDuisburg,
                Germany.HansaRostock,
                Germany.ScVerl,
                Germany.AlemanniaAachen,
                Germany.WehenWiesbaden,
                Germany.WaldhofMannheim,
                Germany.ViktoriaKoeln,
                Germany.FcIngolstadt,
                Germany.JahnRegensburg,
                Germany.VfbStuttgart2,
                Germany.FcSaarbruecken,
                Germany.TsgHoffenheim2,
                Germany.SvMeppen,
                Germany.SonnenhofGrossasbach,
                Germany.FortunaKoeln,
                Germany.WuerzburgerKickers,
                Germany.TsvHavelse
            ]
        };

        /// <summary>
        ///     Representing the first English division
        /// </summary>
        public static readonly League Eng1 = new()
        {
            Id = "ENG_1",
            Name = "Premier League",
            Season = "2026/27",
            ImageKey = "en_1",
            Clubs =
            [
                England.Arsenal,
                England.AstonVilla,
                England.Bournemouth,
                England.Brentford,
                England.BrightonHoveAlbion,
                England.ChelseaFc,
                England.CrystalPalace,
                England.FcEverton,
                England.FcFulham,
                England.LeedsUnited,
                England.LiverpoolFc,
                England.ManCity,
                England.ManUnited,
                England.NewcastleUnited,
                England.NottinghamForest,
                England.SunderlandFc,
                England.Tottenham,
                England.CoventryCity,
                England.HullCity,
                England.IpswichTown
            ]
        };

        public static readonly League Esp1 = new()
        {
            Id = "ESP_1",
            Name = "La Liga",
            Season = "2026/27",
            ImageKey = "es_1",
            Clubs =
            [
                Spain.FcBarcelona,
                Spain.RealMadrid,
                Spain.VillarealCf,
                Spain.AtleticoMadrid,
                Spain.RealBetis,
                Spain.CeltaVigo,
                Spain.GetafeCf,
                Spain.RayoVallecano,
                Spain.ValenciaFc,
                Spain.RealSociedad,
                Spain.RcdEspanyol,
                Spain.AthleticClub,
                Spain.SevillaFc,
                Spain.DeportivoAlaves,
                Spain.ElcheCf,
                Spain.LevanteUd,
                Spain.CaOsasuna,
                Spain.RealRacingClub,
                Spain.RcDeportivo,
                Spain.MalagaCf
            ]
        };

        public static readonly League Ita1 = new()
        {
            Id = "ITA_1",
            Name = "Serie A",
            Season = "2026/27",
            ImageKey = "it_1",
            Clubs =
            [
                Italy.AtalantaBc,
                Italy.BolognaFc,
                Italy.Cagliari,
                Italy.Como,
                Italy.AcfFiorentina,
                Italy.FrosinoneCalcio,
                Italy.GenoaCfc,
                Italy.InterMilan,
                Italy.Juventus,
                Italy.SsLazio,
                Italy.UsLecce,
                Italy.AcMilan,
                Italy.AcMonza,
                Italy.SscNapoli,
                Italy.ParmaCalcio,
                Italy.AsRoma,
                Italy.UsSassuolo,
                Italy.Torino,
                Italy.UdineseCalcio,
                Italy.VeneziaFc,
            ]
        };

        /// <summary>
        ///     Representing the FIFA World Cup
        /// </summary>
        public static readonly League FifaWorldCup = new()
        {
            Id = "INT_WorldCup",
            Name = "FIFA World Cup",
            Season = "2026",
            ImageKey = "wc_26",
            Clubs =
            [
                International.Canada,
                International.Mexico,
                International.UnitedStates,
                International.Algeria,
                International.Argentina,
                International.Australia,
                International.Austria,
                International.Belgium,
                International.BosniaHerzegovina,
                International.Brazil,
                International.CaboVerde,
                International.Colombia,
                International.CongoDr,
                International.CoteDIvoire,
                International.Croatia,
                International.Curacao,
                International.Czechia,
                International.Ecuador,
                International.Egypt,
                International.England,
                International.France,
                International.Germany,
                International.Ghana,
                International.Haiti,
                International.IrIran,
                International.Iraq,
                International.Japan,
                International.Jordan,
                International.KoreaRepublic,
                International.Morocco,
                International.Netherlands,
                International.NewZealand,
                International.Norway,
                International.Panama,
                International.Paraguay,
                International.Portugal,
                International.Qatar,
                International.SaudiArabia,
                International.Scotland,
                International.Senegal,
                International.SouthAfrica,
                International.Spain,
                International.Sweden,
                International.Switzerland,
                International.Tunisia,
                International.Tuerkiye,
                International.Uruguay,
                International.Uzbekistan
            ]
        };
    }
}

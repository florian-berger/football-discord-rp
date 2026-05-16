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
            Season = "2025/26",
            ImageKey = "de_1",
            Clubs =
            [
                Germany.BayernMuenchen,
                Germany.BayerLeverkusen,
                Germany.EintrachtFrankfurt,
                Germany.BorussiaDortmund,
                Germany.ScFreiburg,
                Germany.FsvMainz,
                Germany.RbLeipzig,
                Germany.WerderBremen,
                Germany.VfbStuttgart,
                Germany.BorussiaMoenchengladbach,
                Germany.VflWolfsburg,
                Germany.FcAugsburg,
                Germany.UnionBerlin,
                Germany.StPauli,
                Germany.TsgHoffenheim,
                Germany.FcHeidenheim,
                Germany.FcKoeln,
                Germany.HamburgerSv
            ]
        };

        /// <summary>
        ///     Representing the second German division
        /// </summary>
        public static readonly League Ger2 = new()
        {
            Id = "DEU_2",
            Name = "2. Bundesliga",
            Season = "2025/26",
            ImageKey = "de_2",
            Clubs =
            [
                Germany.HosteinKiel,
                Germany.VflBochum,
                Germany.SvElversberg,
                Germany.ScPaderborn,
                Germany.FcMagdeburg,
                Germany.FortunaDuesseldorf,
                Germany.FcKaiserslautern,
                Germany.KarlsruherSc,
                Germany.Hannover,
                Germany.FcNuernberg,
                Germany.HerthaBsc,
                Germany.SvDarmstadt,
                Germany.GreutherFuerth,
                Germany.FcSchalke,
                Germany.PreussenMuenster,
                Germany.EintrachtBraunschweig,
                Germany.ArminiaBielefeld,
                Germany.DynamoDresden,
            ]
        };

        /// <summary>
        ///     Representing the third German division
        /// </summary>
        public static readonly League Ger3 = new()
        {
            Id = "DEU_3",
            Name = "3. Liga",
            Season = "2025/26",
            Clubs =
            [
                Germany.VflOsnabrueck,
                Germany.EnergieCottbus,
                Germany.RotWeissEssen,
                Germany.MsvDuisburg,
                Germany.HansaRostock,
                Germany.ScVerl,
                Germany.AlemanniaAachen,
                Germany.TsvMuenchen,
                Germany.WehenWiesbaden,
                Germany.WaldhofMannheim,
                Germany.ViktoriaKoeln,
                Germany.JahnRegensburg,
                Germany.FcIngolstadt,
                Germany.VfbStuttgart2,
                Germany.FcSaarbruecken,
                Germany.TsgHoffenheim2,
                Germany.TsvHavelse,
                Germany.SsvUlm,
                Germany.ErzgebirgeAue,
                Germany.FcSchweinfurt,
            ]
        };

        /// <summary>
        ///     Representing the first English division
        /// </summary>
        public static readonly League Eng1 = new()
        {
            Id = "ENG_1",
            Name = "Premier League",
            Season = "2025/26",
            Clubs =
            [
                England.LiverpoolFc,
                England.Arsenal,
                England.ManCity,
                England.ChelseaFc,
                England.NewcastleUnited,
                England.AstonVilla,
                England.NottinghamForest,
                England.BrightonHoveAlbion,
                England.Bournemouth,
                England.Brentford,
                England.FcFulham,
                England.CrystalPalace,
                England.FcEverton,
                England.WestHam,
                England.ManUnited,
                England.Wolverhamption,
                England.Tottenham,
                England.LeedsUnited,
                England.BurnleyFc,
                England.SunderlandFc
            ]
        };

        public static readonly League Esp1 = new()
        {
            Id = "ESP_1",
            Name = "La Liga",
            Season = "2025/26",
            Clubs =
            [
                Spain.AthleticClub,
                Spain.AtleticoMadrid,
                Spain.FcBarcelona,
                Spain.CaOsasuna,
                Spain.CeltaVigo,
                Spain.DeportivoAlaves,
                Spain.ElcheCf,
                Spain.GetafeCf,
                Spain.GironaFc,
                Spain.LevanteUd,
                Spain.RayoVallecano,
                Spain.RcdEspanyol,
                Spain.RcdMallorca,
                Spain.RealBetis,
                Spain.RealMadrid,
                Spain.RealOviedo,
                Spain.RealSociedad,
                Spain.SevillaFc,
                Spain.ValenciaFc,
                Spain.VillarealCf,
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

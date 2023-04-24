using JourneyTrend.Items.Vanity.AndromedaPilot;
using JourneyTrend.Items.Vanity.ArcaneExosuit;
using JourneyTrend.Items.Vanity.Birdie;
using JourneyTrend.Items.Vanity.BountyHunter;
using JourneyTrend.Items.Vanity.BrokenHero;
using JourneyTrend.Items.Vanity.Bubblehead;
using JourneyTrend.Items.Vanity.ContainmentSuit;
using JourneyTrend.Items.Vanity.CosmicTerror;
using JourneyTrend.Items.Vanity.CrystalLegacy;
using JourneyTrend.Items.Vanity.CyberAngel;
using JourneyTrend.Items.Vanity.DeepDiver;
using JourneyTrend.Items.Vanity.Draugr;
using JourneyTrend.Items.Vanity.Duality;
using JourneyTrend.Items.Vanity.ForestDruid;
using JourneyTrend.Items.Vanity.Granite;
using JourneyTrend.Items.Vanity.Grid;
using JourneyTrend.Items.Vanity.HellWarden;
using JourneyTrend.Items.Vanity.Hivenet;
using JourneyTrend.Items.Vanity.IronCore;
using JourneyTrend.Items.Vanity.Journeyman;
using JourneyTrend.Items.Vanity.Kingfisher;
using JourneyTrend.Items.Vanity.KnightOfJudgement;
using JourneyTrend.Items.Vanity.Knightwalker;
using JourneyTrend.Items.Vanity.Kuijia;
using JourneyTrend.Items.Vanity.MagicGrill;
using JourneyTrend.Items.Vanity.Mothron;
using JourneyTrend.Items.Vanity.MushroomAlchemist;
using JourneyTrend.Items.Vanity.Nexus;
using JourneyTrend.Items.Vanity.Nightlight;
using JourneyTrend.Items.Vanity.NineTailedFox;
using JourneyTrend.Items.Vanity.Pilot;
using JourneyTrend.Items.Vanity.Planetary;
using JourneyTrend.Items.Vanity.PoweredPanoply;
using JourneyTrend.Items.Vanity.Rookie;
using JourneyTrend.Items.Vanity.SeaBuckthornTea;
using JourneyTrend.Items.Vanity.SeaHunter;
using JourneyTrend.Items.Vanity.ShadowFiend;
using JourneyTrend.Items.Vanity.ShadowSpell;
using JourneyTrend.Items.Vanity.Shark;
using JourneyTrend.Items.Vanity.Shootsaton;
using JourneyTrend.Items.Vanity.StarlightDream;
using JourneyTrend.Items.Vanity.StormConqueror;
using JourneyTrend.Items.Vanity.SwampHorror;
using JourneyTrend.Items.Vanity.Terra;
using JourneyTrend.Items.Vanity.Traveller;
using JourneyTrend.Items.Vanity.Treesuit;
using JourneyTrend.Items.Vanity.WitchsVoid;
using JourneyTrend.Items.Vanity.WyvernRider;
using Terraria.ModLoader;

namespace JourneyTrend.NPCs.Trader;

public partial class VanityTrader
{
    private static readonly int[] ShopItems =
    {
        ModContent.ItemType<AndromedaPilotBag>(),
        ModContent.ItemType<ArcaneExosuitBag>(),
        ModContent.ItemType<BirdieBag>(),
        ModContent.ItemType<BountyHunterBag>(),
        ModContent.ItemType<BrokenHeroBag>(),
        ModContent.ItemType<BubbleheadBag>(),
        ModContent.ItemType<ContainmentSuitBag>(),
        ModContent.ItemType<CosmicTerrorBag>(),
        ModContent.ItemType<CrystalLegacyBag>(),
        ModContent.ItemType<CyberAngelBag>(),
        ModContent.ItemType<DeepDiverBag>(),
        ModContent.ItemType<DraugrBag>(),
        ModContent.ItemType<DualityBag>(),
        ModContent.ItemType<ForestDruidBag>(),
        ModContent.ItemType<GraniteBag>(),
        ModContent.ItemType<GridBag>(),
        ModContent.ItemType<HellWardenBag>(),
        ModContent.ItemType<HivenetBag>(),
        ModContent.ItemType<IronCoreBag>(),
        ModContent.ItemType<JourneymanBag>(),
        ModContent.ItemType<KingfisherBag>(),
        ModContent.ItemType<KnightOfJudgementBag>(),
        ModContent.ItemType<KnightwalkerBag>(),
        ModContent.ItemType<KuijiaBag>(),
        ModContent.ItemType<MagicGrillBag>(),
        ModContent.ItemType<MothronBag>(),
        ModContent.ItemType<MushroomAlchemistBag>(),
        ModContent.ItemType<NexusBag>(),
        ModContent.ItemType<NightlightBag>(),
        ModContent.ItemType<NineTailedFoxBag>(),
        ModContent.ItemType<PilotBag>(),
        ModContent.ItemType<PlanetaryBag>(),
        ModContent.ItemType<PoweredPanoplyBag>(),
        ModContent.ItemType<RookieBag>(),
        ModContent.ItemType<SeaBuckthornTeaBag>(),
        ModContent.ItemType<SeaHunterBag>(),
        ModContent.ItemType<ShadowFiendBag>(),
        ModContent.ItemType<ShadowSpellBag>(),
        ModContent.ItemType<SharkBag>(),
        ModContent.ItemType<ShootsatonBag>(),
        ModContent.ItemType<StarlightDreamBag>(),
        ModContent.ItemType<StormConquerorBag>(),
        ModContent.ItemType<SwampHorrorBag>(),
        ModContent.ItemType<TerraBag>(),
        ModContent.ItemType<TravellerBag>(),
        ModContent.ItemType<TreesuitBag>(),
        ModContent.ItemType<WitchsVoidBag>(),
        ModContent.ItemType<WyvernRiderBag>(),
    };
}
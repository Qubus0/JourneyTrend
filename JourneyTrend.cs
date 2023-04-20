using System.Linq;
using JourneyTrend.Items.Vanity.Bubblehead;
using JourneyTrend.Items.Vanity.CyberAngel;
using JourneyTrend.Items.Vanity.ForestDruid;
using JourneyTrend.Items.Vanity.Knightwalker;
using JourneyTrend.Items.Vanity.ShadowFiend;
using JourneyTrend.Items.Vanity.Terra;
using JourneyTrend.NPCs.Trader;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace JourneyTrend
{
    public class JourneyTrend : Mod
    {
        public override void Load()
        {
            // Will show up in client.log under the JourneyTrend name
            Logger.InfoFormat("{0} Logs: ", Name);
        }

        public override void Unload()
        {
            // All code below runs only if we're not loading on a server
            // if (!Main.dedServ) {
            // 	
            // }

            // Unload static references
            // You need to clear static references to assets (Texture2D, SoundEffects, Effects).
            // In addition to that, if you want your mod to completely unload during unload, you need to clear static references to anything referencing your Mod class
            if (VanityTrader.CurrentShop?.Any() == true)
            {
                VanityTrader.CurrentShop.Clear();
            }
        }

        public override void AddRecipeGroups()/* tModPorter Note: Removed. Use ModSystem.AddRecipeGroups */
        {
            // Crafting Recipe Groups
            var SilverBars = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Silver Bar",
                ItemID.SilverBar, ItemID.TungstenBar);
            RecipeGroup.RegisterGroup("JourneyTrend:SilverBars", SilverBars);

            // Sewing Machine Variant Recipe Groups
            var CyberHalos = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Cyber Halo",
                ModContent.ItemType<CyberAngelHead>(), ModContent.ItemType<CyberAngelHead1>());
            RecipeGroup.RegisterGroup("JourneyTrend:CyberHalos", CyberHalos);

            var DruidMasks = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Druid Mask",
                ModContent.ItemType<ForestDruidHead>(), ModContent.ItemType<ForestDruidHead1>(),
                ModContent.ItemType<ForestDruidHead2>());
            RecipeGroup.RegisterGroup("JourneyTrend:DruidMasks", DruidMasks);

            // var KnightwalkerCapes = new RecipeGroup(
            //     () => Language.GetTextValue("LegacyMisc.37") + " Cape of the Knightwalker",
            //     ModContent.ItemType<KnightwalkerBody>(), ModContent.ItemType<KnightwalkerBody1>());
            // RecipeGroup.RegisterGroup("JourneyTrend:KnightwalkerCapes", KnightwalkerCapes);

            var BubbleHeads = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Bubblehead",
                ModContent.ItemType<BubbleheadHead>(), ModContent.ItemType<BubbleheadHead1>(),
                ModContent.ItemType<BubbleheadHead2>(), ModContent.ItemType<BubbleheadHead3>(),
                ModContent.ItemType<BubbleheadHead4>(), ModContent.ItemType<BubbleheadHead5>(),
                ModContent.ItemType<BubbleheadHead6>());
            RecipeGroup.RegisterGroup("JourneyTrend:BubbleHeads", BubbleHeads);

            var TerraCrowns = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Terra Crown",
                ModContent.ItemType<TerraHead>(), ModContent.ItemType<TerraHead1>());
            RecipeGroup.RegisterGroup("JourneyTrend:TerraCrowns", TerraCrowns);

            var WorldEvilDemonHeads = new RecipeGroup(
                () => Language.GetTextValue("LegacyMisc.37") + " World Evil Demon's Head",
                ModContent.ItemType<ShadowFiendHead>(), ModContent.ItemType<ShadowFiendHead1>());
            RecipeGroup.RegisterGroup("JourneyTrend:WorldEvilDemonHeads", WorldEvilDemonHeads);

            var WorldEvilDemonBodies = new RecipeGroup(
                () => Language.GetTextValue("LegacyMisc.37") + " World Evil Demon's Body",
                ModContent.ItemType<ShadowFiendBody>(), ModContent.ItemType<ShadowFiendBody1>());
            RecipeGroup.RegisterGroup("JourneyTrend:WorldEvilDemonBodies", WorldEvilDemonBodies);

            var WorldEvilDemonLegs = new RecipeGroup(
                () => Language.GetTextValue("LegacyMisc.37") + " World Evil Demon's Legs",
                ModContent.ItemType<ShadowFiendLegs>(), ModContent.ItemType<ShadowFiendLegs1>());
            RecipeGroup.RegisterGroup("JourneyTrend:WorldEvilDemonLegs", WorldEvilDemonLegs);
        }
    }
}
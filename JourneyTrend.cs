using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;


namespace JourneyTrend
{
    public class JourneyTrend : Mod
    {
        public static Vector2 ScalePoint(Vector2 a, Vector2 c, float t) =>
            new Vector2(c.X + (t * (a.X - c.X)), c.Y + (t * (a.Y - c.Y)));

        public JourneyTrend()
        {
        }

        public override void Load()
        {
            // Will show up in client.log under the JourneyTrend name
            Logger.InfoFormat("{0} Logs: ", Name);
            if (!Main.dedServ)
            {
                AddEquipTexture(null, EquipType.Legs, "PilotBody_Legs",
                    "JourneyTrend/Items/Vanity/Pilot/PilotBody_Legs");
            }
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
            NPCs.Trader.VanityTrader.currentShop.Clear();
        }

        public override void AddRecipeGroups()
        {
            // Crafting Recipe Groups
            RecipeGroup SilverBars = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Silver Bar",
                new int[]
                {
                    ItemID.SilverBar,
                    ItemID.TungstenBar
                });
            RecipeGroup.RegisterGroup("JourneyTrend:SilverBars", SilverBars);

            // Sewing Machine Variant Recipe Groups
            RecipeGroup CyberHalos = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Cyber Halo",
                new int[]
                {
                    ModContent.ItemType<Items.Vanity.CyberAngel.CyberAngelHead>(),
                    ModContent.ItemType<Items.Vanity.CyberAngel.CyberAngelHead1>()
                });
            RecipeGroup.RegisterGroup("JourneyTrend:CyberHalos", CyberHalos);

            RecipeGroup DruidMasks = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Druid Mask",
                new int[]
                {
                    ModContent.ItemType<Items.Vanity.ForestDruid.ForestDruidHead>(),
                    ModContent.ItemType<Items.Vanity.ForestDruid.ForestDruidHead1>(),
                    ModContent.ItemType<Items.Vanity.ForestDruid.ForestDruidHead2>()
                });
            RecipeGroup.RegisterGroup("JourneyTrend:DruidMasks", DruidMasks);

            RecipeGroup KnightwalkerCapes = new RecipeGroup(
                () => Language.GetTextValue("LegacyMisc.37") + " Cape of the Knightwalker", new int[]
                {
                    ModContent.ItemType<Items.Vanity.Knightwalker.KnightwalkerBody>(),
                    ModContent.ItemType<Items.Vanity.Knightwalker.KnightwalkerBody1>()
                });
            RecipeGroup.RegisterGroup("JourneyTrend:KnightwalkerCapes", KnightwalkerCapes);

            RecipeGroup BubbleHeads = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Bubblehead",
                new int[]
                {
                    ModContent.ItemType<Items.Vanity.Bubblehead.BubbleheadHead>(),
                    ModContent.ItemType<Items.Vanity.Bubblehead.BubbleheadHead1>(),
                    ModContent.ItemType<Items.Vanity.Bubblehead.BubbleheadHead2>(),
                    ModContent.ItemType<Items.Vanity.Bubblehead.BubbleheadHead3>(),
                    ModContent.ItemType<Items.Vanity.Bubblehead.BubbleheadHead4>(),
                    ModContent.ItemType<Items.Vanity.Bubblehead.BubbleheadHead5>(),
                    ModContent.ItemType<Items.Vanity.Bubblehead.BubbleheadHead6>()
                });
            RecipeGroup.RegisterGroup("JourneyTrend:BubbleHeads", BubbleHeads);

            RecipeGroup TerraCrowns = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Terra Crown",
                new int[]
                {
                    ModContent.ItemType<Items.Vanity.Terra.TerraHead>(),
                    ModContent.ItemType<Items.Vanity.Terra.TerraHead1>()
                });
            RecipeGroup.RegisterGroup("JourneyTrend:TerraCrowns", TerraCrowns);

            RecipeGroup WorldEvilDemonHeads = new RecipeGroup(
                () => Language.GetTextValue("LegacyMisc.37") + " World Evil Demon's Head", new int[]
                {
                    ModContent.ItemType<Items.Vanity.ShadowFiend.ShadowFiendHead>(),
                    ModContent.ItemType<Items.Vanity.ShadowFiend.ShadowFiendHead1>()
                });
            RecipeGroup.RegisterGroup("JourneyTrend:WorldEvilDemonHeads", WorldEvilDemonHeads);

            RecipeGroup WorldEvilDemonBodies = new RecipeGroup(
                () => Language.GetTextValue("LegacyMisc.37") + " World Evil Demon's Body", new int[]
                {
                    ModContent.ItemType<Items.Vanity.ShadowFiend.ShadowFiendBody>(),
                    ModContent.ItemType<Items.Vanity.ShadowFiend.ShadowFiendBody1>()
                });
            RecipeGroup.RegisterGroup("JourneyTrend:WorldEvilDemonBodies", WorldEvilDemonBodies);

            RecipeGroup WorldEvilDemonLegs = new RecipeGroup(
                () => Language.GetTextValue("LegacyMisc.37") + " World Evil Demon's Legs", new int[]
                {
                    ModContent.ItemType<Items.Vanity.ShadowFiend.ShadowFiendLegs>(),
                    ModContent.ItemType<Items.Vanity.ShadowFiend.ShadowFiendLegs1>()
                });
            RecipeGroup.RegisterGroup("JourneyTrend:WorldEvilDemonLegs", WorldEvilDemonLegs);
        }
    }
}
using JourneyTrend.Items.Vanity.Bubblehead;
using JourneyTrend.Items.Vanity.CyberAngel;
using JourneyTrend.Items.Vanity.ForestDruid;
using JourneyTrend.Items.Vanity.ShadowFiend;
using JourneyTrend.Items.Vanity.Terra;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace JourneyTrend;

public class JourneyRecipes : ModSystem
{
    public override void AddRecipeGroups()
    {
        string wordAnyTranslated = Language.GetTextValue("LegacyMisc.37");

        var silverBars = new RecipeGroup(() => wordAnyTranslated + " Silver Bar",
            ItemID.SilverBar, ItemID.TungstenBar);
        RecipeGroup.RegisterGroup("JourneyTrend:SilverBars", silverBars);

        // Sewing Machine Variant Recipe Groups
        var cyberHalos = new RecipeGroup(() => wordAnyTranslated + " Cyber Halo",
            ModContent.ItemType<CyberAngelHead>(), ModContent.ItemType<CyberAngelHead1>());
        RecipeGroup.RegisterGroup("JourneyTrend:CyberHalos", cyberHalos);

        var druidMasks = new RecipeGroup(() => wordAnyTranslated + " Druid Mask",
            ModContent.ItemType<ForestDruidHead>(), ModContent.ItemType<ForestDruidHead1>(),
            ModContent.ItemType<ForestDruidHead2>());
        RecipeGroup.RegisterGroup("JourneyTrend:DruidMasks", druidMasks);

        // var KnightwalkerCapes = new RecipeGroup(
        //     () => wordAnyTranslated + " Cape of the Knightwalker",
        //     ModContent.ItemType<KnightwalkerBody>(), ModContent.ItemType<KnightwalkerBody1>());
        // RecipeGroup.RegisterGroup("JourneyTrend:KnightwalkerCapes", KnightwalkerCapes);

        var bubbleHeads = new RecipeGroup(() => wordAnyTranslated + " Bubblehead",
            ModContent.ItemType<BubbleheadHead>(), ModContent.ItemType<BubbleheadHead1>(),
            ModContent.ItemType<BubbleheadHead2>(), ModContent.ItemType<BubbleheadHead3>(),
            ModContent.ItemType<BubbleheadHead4>(), ModContent.ItemType<BubbleheadHead5>(),
            ModContent.ItemType<BubbleheadHead6>());
        RecipeGroup.RegisterGroup("JourneyTrend:BubbleHeads", bubbleHeads);

        var terraCrowns = new RecipeGroup(() => wordAnyTranslated + " Terra Crown",
            ModContent.ItemType<TerraHead>(), ModContent.ItemType<TerraHead1>());
        RecipeGroup.RegisterGroup("JourneyTrend:TerraCrowns", terraCrowns);

        var worldEvilDemonHeads = new RecipeGroup(
            () => wordAnyTranslated + " World Evil Demon's Head",
            ModContent.ItemType<ShadowFiendHead>(), ModContent.ItemType<ShadowFiendHead1>());
        RecipeGroup.RegisterGroup("JourneyTrend:WorldEvilDemonHeads", worldEvilDemonHeads);

        var worldEvilDemonBodies = new RecipeGroup(
            () => wordAnyTranslated + " World Evil Demon's Body",
            ModContent.ItemType<ShadowFiendBody>(), ModContent.ItemType<ShadowFiendBody1>());
        RecipeGroup.RegisterGroup("JourneyTrend:WorldEvilDemonBodies", worldEvilDemonBodies);

        var worldEvilDemonLegs = new RecipeGroup(
            () => wordAnyTranslated + " World Evil Demon's Legs",
            ModContent.ItemType<ShadowFiendLegs>(), ModContent.ItemType<ShadowFiendLegs1>());
        RecipeGroup.RegisterGroup("JourneyTrend:WorldEvilDemonLegs", worldEvilDemonLegs);
    }
}
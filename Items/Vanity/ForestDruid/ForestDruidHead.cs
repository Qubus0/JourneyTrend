using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.ForestDruid
{
    [AutoloadEquip(EquipType.Head)]
    public class ForestDruidHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Forest Druid's Horns");
            Tooltip.SetDefault("Like animal horns, branches have grown in your head\nMade by Kohi_aue");
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Green;
            Item.vanity = true;
        }

        public override void DrawHair(ref bool drawHair, ref bool drawAltHair)
        {
            drawHair = true;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
            .AddTile<Tiles.SewingMachine>()
            .AddRecipeGroup("JourneyTrend:DruidMasks")
            .Register();
        }
    }
}
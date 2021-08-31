using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Terra
{
    [AutoloadEquip(EquipType.Head)]
    public class TerraHead1 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Terra Crown");
            Tooltip.SetDefault(
                "A crown powered by the force of nature\nIts said that the powers of light and dark are inside it as well\nFits your hair just right!\nMade by TerraKingCole614");
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Lime;
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
            .AddRecipeGroup("JourneyTrend:TerraCrowns")
            .Register();
        }
    }
}
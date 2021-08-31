using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.SeaHunter
{
    [AutoloadEquip(EquipType.Head)]
    public class SeaHunterHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sea Hunter's Trifold Hat");
            Tooltip.SetDefault("May the hunt commence\nMade by Authon");
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Blue;
            Item.vanity = true;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddTile(TileID.Loom)
                .AddIngredient(ItemID.Silk, 10)
                .AddIngredient(ItemID.SharkFin, 5)
                .Register();
        }

        public override void DrawHair(ref bool drawHair, ref bool drawAltHair)
        {
            drawAltHair = true;
        }
    }
}
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.SeaHunter
{
    [AutoloadEquip(EquipType.Legs)]
    public class SeaHunterLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sea Hunter's Boots");
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
    }
}
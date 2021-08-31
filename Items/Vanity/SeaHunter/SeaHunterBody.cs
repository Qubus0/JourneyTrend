using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.SeaHunter
{
    [AutoloadEquip(EquipType.Body)]
    public class SeaHunterBody : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sea Hunter's Longcoat");
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
                .AddIngredient(ItemID.Silk, 15)
                .AddIngredient(ItemID.SharkFin, 5)
                .Register();
        }
    }
}
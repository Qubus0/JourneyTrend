using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.CrystalLegacy
{
    [AutoloadEquip(EquipType.Legs)]
    public class CrystalLegacyLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Crystal Greaves");
            Tooltip.SetDefault("Greaves burdened by crystal growths...\nMade by Curt 'Bucket Face' Black");
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Orange;
            Item.vanity = true;
            Item.value = 0;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.CrystalShard, 15)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}
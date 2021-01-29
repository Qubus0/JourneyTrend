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
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Orange;
            item.vanity = true;
            item.value = 0;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CrystalShard, 15);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}

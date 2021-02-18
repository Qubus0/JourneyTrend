using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Hivenet
{
    [AutoloadEquip(EquipType.Legs)]
    public class HivenetLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("HiveNet Leggings");
            Tooltip.SetDefault("Complete with 2 bytes of ram.\nMade by Sam Holt");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Green;
            item.vanity = true;
        }

        public override void AddRecipes()
        {
            var recipe = new ModRecipe(mod);
            recipe.AddTile(TileID.Anvils);
            recipe.AddIngredient(ItemID.CopperBar, 10);
            recipe.AddIngredient(ItemID.BeeWax, 5);
            recipe.AddIngredient(ItemID.Wire, 3);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddTile(TileID.Anvils);
            recipe.AddIngredient(ItemID.TinBar, 10);
            recipe.AddIngredient(ItemID.BeeWax, 5);
            recipe.AddIngredient(ItemID.Wire, 3);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
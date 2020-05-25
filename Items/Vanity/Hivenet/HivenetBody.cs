using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyTrend.Items.Vanity.Hivenet
{
    [AutoloadEquip(EquipType.Body)]
    public class HivenetBody : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("HiveNet Chestplate");
            Tooltip.SetDefault("Not as Protective as it Looks\nMade by Sam Holt");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = 2;
            item.vanity = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddTile(TileID.Anvils);
            recipe.AddIngredient(ItemID.CopperBar, 10);
            recipe.AddIngredient(ItemID.BeeWax, 8);
            recipe.AddIngredient(ItemID.Wire, 5);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddTile(TileID.Anvils);
            recipe.AddIngredient(ItemID.TinBar, 10);
            recipe.AddIngredient(ItemID.BeeWax, 8);
            recipe.AddIngredient(ItemID.Wire, 5);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
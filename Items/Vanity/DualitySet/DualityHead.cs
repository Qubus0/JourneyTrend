using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyTrend.Items.Vanity.DualitySet
{
    [AutoloadEquip(EquipType.Head)]
    public class DualityHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("[c/6e658e:Duality Mask]");
            Tooltip.SetDefault("Good and evil, mind of two worlds.\nMade by Chan.");
        }
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.vanity = true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LightShard, 1);
            recipe.AddIngredient(ItemID.DarkShard, 1);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override bool DrawHead()
        {
            return false;
        }
    }
}
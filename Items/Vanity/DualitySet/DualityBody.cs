using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyTrend.Items.Vanity.DualitySet
{
    [AutoloadEquip(EquipType.Body)]
    public class DualityBody : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("[c/6e658e:Duality Shirt]");
            Tooltip.SetDefault("Light and dark, perfectly balanced as all things should be.\nMade by Chan.");
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
        public override bool DrawBody()
        {
            return false;
        }
    }
}
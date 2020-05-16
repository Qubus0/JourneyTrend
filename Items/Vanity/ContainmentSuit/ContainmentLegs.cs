using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyTrend.Items.Vanity.ContainmentSuit
{
    [AutoloadEquip(EquipType.Legs)]
    public class ContainmentLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Containment Boots");
            Tooltip.SetDefault("A traveler's boots for harsh environments.\nMade by MikeLeaArt.");
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
            recipe.AddIngredient(ItemID.Silk, 2);
            recipe.AddIngredient(ItemID.Wire, 2);
            recipe.AddRecipeGroup("IronBar", 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
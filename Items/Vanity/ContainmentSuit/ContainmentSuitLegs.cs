using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.ContainmentSuit
{
    [AutoloadEquip(EquipType.Legs)]
    public class ContainmentSuitLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Containment Boots");
            Tooltip.SetDefault("A traveler's boots for harsh environments.\nMade by MikeLeaArt");
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
            recipe.AddIngredient(ItemID.Silk, 2);
            recipe.AddIngredient(ItemID.Wire, 2);
            recipe.AddRecipeGroup("IronBar", 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
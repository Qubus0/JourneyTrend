using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.ContainmentSuit
{
    [AutoloadEquip(EquipType.Head)]
    public class ContainmentSuitHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Containment Helmet");
            Tooltip.SetDefault("A traveler's helmet for harsh environments.\nMade by MikeLeaArt");
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
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Glass, 2);
            recipe.AddIngredient(ItemID.Wire, 3);
            recipe.AddIngredient(ItemID.Topaz, 1);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
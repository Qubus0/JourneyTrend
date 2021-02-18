using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.PoweredPanoply
{
    [AutoloadEquip(EquipType.Head)]
    public class PoweredPanoplyHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Powered Armet");
            Tooltip.SetDefault("'Three fourths and a fifth'\nMade by Fake_Tank");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Blue;
            item.vanity = true;
            item.value = 0;
        }

        public override void AddRecipes()
        {
            var recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Nanites, 20);
            recipe.AddRecipeGroup("JourneyTrend:SilverBars", 6);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
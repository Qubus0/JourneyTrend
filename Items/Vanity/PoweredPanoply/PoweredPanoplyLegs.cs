using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.PoweredPanoply
{
    [AutoloadEquip(EquipType.Legs)]
    public class PoweredPanoplyLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Powered Cuisses");
            Tooltip.SetDefault("Made by Fake_Tank");
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
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Nanites, 15);
            recipe.AddRecipeGroup("JourneyTrend:SilverBars", 8);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.PoweredPanoply
{
    [AutoloadEquip(EquipType.Body)]
    public class PoweredBody : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Powered Breastplate");
            Tooltip.SetDefault("Made by Fake_Tank");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Blue;
            item.vanity = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Nanites, 25);
            recipe.AddIngredient(ItemID.SilverBar, 12);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Nanites, 25);
            recipe.AddIngredient(ItemID.TungstenBar, 12);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
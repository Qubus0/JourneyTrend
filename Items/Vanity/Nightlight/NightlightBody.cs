using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyTrend.Items.Vanity.Nightlight
{
    [AutoloadEquip(EquipType.Body)]
    public class NightlightBody : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nightlight Body");
            Tooltip.SetDefault("A bright friendly glow in the night.\nMade by Metalsquirrel.");
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
            recipe.AddTile(TileID.Loom);
            recipe.AddIngredient(ItemID.Silk, 15);
            recipe.AddIngredient(ItemID.Moonglow, 15);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
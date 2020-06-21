using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Nightlight
{
    [AutoloadEquip(EquipType.Head)]
    public class NightlightHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nightlight Eyes");
            Tooltip.SetDefault("Eyes that reflect a moonlit night...\nMade by Metalsquirrel");
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
            recipe.AddTile(TileID.Loom);
            recipe.AddIngredient(ItemID.Silk, 15);
            recipe.AddIngredient(ItemID.Moonglow, 5);
            recipe.AddIngredient(ItemID.Lens, 2);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyTrend.Items.Vanity.SeaHunter
{
    [AutoloadEquip(EquipType.Head)]
    public class SeaHunterHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sea Hunter's Trifold Hat");
            Tooltip.SetDefault("May the hunt commence\nMade by Authon");
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
            recipe.AddTile(TileID.Loom);
            recipe.AddIngredient(ItemID.Silk, 10);
            recipe.AddIngredient(ItemID.SharkFin, 5);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override void DrawHair(ref bool drawHair, ref bool drawAltHair)
        {
            drawAltHair = true;
        }
    }
}
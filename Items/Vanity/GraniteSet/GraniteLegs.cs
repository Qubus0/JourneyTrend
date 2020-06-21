using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.GraniteSet
{
    [AutoloadEquip(EquipType.Legs)]
    public class GraniteLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Granite Golem Legs");
            Tooltip.SetDefault("Made by EpicCrownKing");
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
            recipe.AddIngredient(ItemID.DirtBlock, 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
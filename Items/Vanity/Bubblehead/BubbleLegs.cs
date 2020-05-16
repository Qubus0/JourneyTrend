using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyTrend.Items.Vanity.Bubblehead
{
    [AutoloadEquip(EquipType.Legs)]
    public class BubbleLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Carbon Boots");
            Tooltip.SetDefault("Carbon has fantastic properties.\nMade by Metidigiti.");
        }
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = 4;
            item.vanity = true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SoulofNight, 1);
            recipe.AddIngredient(ItemID.Diamond, 2);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
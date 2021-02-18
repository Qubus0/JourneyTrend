using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Bubblehead
{
    [AutoloadEquip(EquipType.Body)]
    public class BubbleheadBody : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hydro Tank v3");
            Tooltip.SetDefault("One of the most modern supply tanks!\nMade by Metidigiti");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.LightRed;
            item.vanity = true;
        }

        public override void AddRecipes()
        {
            var recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BottledWater);
            recipe.AddIngredient(ItemID.Switch);
            recipe.AddIngredient(ItemID.SoulofNight);
            recipe.AddIngredient(ItemID.Wire, 20);
            recipe.AddRecipeGroup("IronBar", 3);
            recipe.needWater = true;
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
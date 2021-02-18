using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Invisible
{
    [AutoloadEquip(EquipType.Body)]
    public class InvisibleBody : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("See");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.White;
            item.vanity = true;
        }

        public override bool DrawBody()
        {
            return false;
        }

        public override void AddRecipes()
        {
            var recipe = new ModRecipe(mod);
            recipe.AddTile(mod.GetTile("SewingMachine"));
            recipe.AddIngredient(ItemID.Glass);
            recipe.needWater = true;
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
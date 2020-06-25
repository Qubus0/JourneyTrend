using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Invisible
{
    [AutoloadEquip(EquipType.Legs)]
    public class InvisibleLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Me");
        }
        
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.White;
            item.vanity = true;
        }

        public override bool DrawLegs()
        {
            return false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddTile(mod.GetTile("SewingMachine"));
            recipe.AddIngredient(ItemID.Glass, 1);
            recipe.needWater = true;
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
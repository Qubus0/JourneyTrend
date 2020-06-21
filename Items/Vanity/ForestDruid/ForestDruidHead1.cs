using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.ForestDruid
{
    [AutoloadEquip(EquipType.Head)]
    public class ForestDruidHead1 : ModItem
    {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Forest Druid's Mask");
            Tooltip.SetDefault("Like animal horns, branches have grown in your head\nMade by Kohi_aue");
        }
        
        public override void SetDefaults() {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Green;
            item.vanity = true;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddTile(mod.GetTile("SewingMachine"));
            recipe.AddRecipeGroup("JourneyTrend:DruidMasks");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}

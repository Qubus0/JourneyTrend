using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyTrend.Items.Vanity.ForestDruid
{
    [AutoloadEquip(EquipType.Head)]
    public class ForestDruidHead : ModItem
    {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Forest Druid's Horns");
            Tooltip.SetDefault("Like animal horns, branches have grown in your head\nMade by Kohi_aue");
        }
        
        public override void SetDefaults() {
            item.width = 18;
            item.height = 18;
            item.rare = 2;
            item.vanity = true;
        }

        public override void DrawHair(ref bool drawHair, ref bool drawAltHair) {
            drawHair = true;
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

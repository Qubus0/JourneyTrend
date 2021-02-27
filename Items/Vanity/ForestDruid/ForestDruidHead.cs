using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.ForestDruid
{
    [AutoloadEquip(EquipType.Head)]
    public class ForestDruidHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Forest Druid's Horns");
            Tooltip.SetDefault("Like animal horns, branches have grown in your head\nMade by Kohi_aue");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Green;
            item.vanity = true;
        }

        public override void DrawHair(ref bool drawHair, ref bool drawAltHair)
        {
            drawHair = true;
        }

        public override void AddRecipes()
        {
            var alt = new ModRecipe(mod);
            alt.AddTile(mod.GetTile("SewingMachine"));
            alt.AddRecipeGroup("JourneyTrend:DruidMasks");
            alt.SetResult(this);
            alt.AddRecipe();
        }
    }
}
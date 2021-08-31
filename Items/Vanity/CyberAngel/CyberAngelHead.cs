using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.CyberAngel
{
    [AutoloadEquip(EquipType.Head)]
    public class CyberAngelHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cyber Halo");
            Tooltip.SetDefault(
                "This armor was designed to restrict,\ncontrol and extract the power and energy of gods,\nangels and powerful beings.\nMade by Rariaz");
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Cyan;
            Item.vanity = true;
            Item.value = 250000; //only if sold.
        }

        public override void DrawHair(ref bool drawHair, ref bool drawAltHair)
        {
            drawHair = true;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
            .AddTile<Tiles.SewingMachine>()
            .AddRecipeGroup("JourneyTrend:CyberHalos")
            .Register();
        }
    }
}
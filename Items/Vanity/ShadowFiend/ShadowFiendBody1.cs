using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.ShadowFiend
{
    [AutoloadEquip(EquipType.Body)]
    public class ShadowFiendBody1 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Crimson Scourge Breastplate");
            Tooltip.SetDefault("Ichor flows through you!\nMade by CakeBoiii");
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.LightRed;
            Item.vanity = true;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
            .AddTile<Tiles.SewingMachine>()
            .AddRecipeGroup("JourneyTrend:WorldEvilDemonBodies")
            .Register();
        }
    }
}
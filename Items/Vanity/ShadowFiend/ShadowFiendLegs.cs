using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.ShadowFiend
{
    [AutoloadEquip(EquipType.Legs)]
    public class ShadowFiendLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Shadow Fiend Leggings");
            Tooltip.SetDefault("Cursed Flames consume you!\nMade by CakeBoiii");
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.LightPurple;
            Item.vanity = true;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
            .AddTile<Tiles.SewingMachine>()
            .AddRecipeGroup("JourneyTrend:WorldEvilDemonLegs")
            .Register();
        }
    }
}
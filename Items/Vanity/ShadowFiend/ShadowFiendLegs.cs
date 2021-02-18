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
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.LightPurple;
            item.vanity = true;
        }

        public override void AddRecipes()
        {
            var alt = new ModRecipe(mod);
            alt.AddTile(mod.GetTile("SewingMachine"));
            alt.AddRecipeGroup("JourneyTrend:WorldEvilDemonLegs");
            alt.SetResult(this);
            alt.AddRecipe();
        }
    }
}
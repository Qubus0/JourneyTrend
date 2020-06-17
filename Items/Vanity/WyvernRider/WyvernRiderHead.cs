using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyTrend.Items.Vanity.WyvernRider
{
    [AutoloadEquip(EquipType.Head)]
    public class WyvernRiderHead : ModItem
    {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Wyvern Rider Hat");
            Tooltip.SetDefault("It doesn't allow you to ride wyverns, sorry.\nMade by manzXja");
        }
        
        public override void SetDefaults() {
            item.width = 18;
            item.height = 18;
            item.rare = 9;
            item.vanity = true;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddTile(TileID.SkyMill);
            recipe.AddIngredient(ItemID.Silk, 5);
            recipe.AddIngredient(ItemID.Cloud, 2);
            recipe.AddIngredient(ItemID.SoulofFlight, 2);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override void DrawHair(ref bool drawHair, ref bool drawAltHair) {
            drawAltHair = true;
        }
    }
}

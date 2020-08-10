using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.HellWarden
{
    [AutoloadEquip(EquipType.Body)]
    public class HellWardenBody : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hell Warden's Chestplate");
            Tooltip.SetDefault("Made by Adrian R.A.");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.LightRed;
            item.vanity = true;
        }

        public override void DrawHands(ref bool drawHands, ref bool drawArms)
        {
            drawHands = false;
            drawArms = false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddTile(TileID.Hellforge);
            recipe.AddIngredient(ItemID.HellstoneBar, 5);
            recipe.AddIngredient(ItemID.LavaBucket, 1);
            recipe.needLava = true;
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
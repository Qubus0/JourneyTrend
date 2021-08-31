using Terraria;
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
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.LightRed;
            Item.vanity = true;
        }

        public override void DrawHands(ref bool drawHands, ref bool drawArms)
        {
            drawHands = false;
            drawArms = false;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddTile(TileID.Hellforge)
                .AddIngredient(ItemID.HellstoneBar, 5)
                .AddIngredient(ItemID.LavaBucket)
                .AddCondition(Recipe.Condition.NearLava)
                .Register();
        }
    }
}
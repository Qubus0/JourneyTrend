using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.HellWarden
{
    [AutoloadEquip(EquipType.Legs)]
    public class HellWardenLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hell Warden's Boots");
            Tooltip.SetDefault("Made by Adrian R.A.");
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
                .AddTile(TileID.Hellforge)
                .AddIngredient(ItemID.HellstoneBar, 5)
                .AddIngredient(ItemID.LavaBucket)
                .AddCondition(Recipe.Condition.NearLava)
                .Register();
        }
    }
}
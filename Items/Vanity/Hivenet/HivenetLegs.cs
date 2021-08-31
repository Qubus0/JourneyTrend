using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Hivenet
{
    [AutoloadEquip(EquipType.Legs)]
    public class HivenetLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("HiveNet Leggings");
            Tooltip.SetDefault("Complete with 2 bytes of ram.\nMade by Sam Holt");
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Green;
            Item.vanity = true;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddTile(TileID.Anvils)
                .AddIngredient(ItemID.CopperBar, 10)
                .AddIngredient(ItemID.BeeWax, 5)
                .AddIngredient(ItemID.Wire, 3)
                .Register();

            CreateRecipe()
                .AddTile(TileID.Anvils)
                .AddIngredient(ItemID.TinBar, 10)
                .AddIngredient(ItemID.BeeWax, 5)
                .AddIngredient(ItemID.Wire, 3)
                .Register();
        }
    }
}
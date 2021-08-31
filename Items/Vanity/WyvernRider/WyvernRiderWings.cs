using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.WyvernRider
{
    [AutoloadEquip(EquipType.Wings)]
    public class WyvernRiderWings : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Wyvern Rider Tail");
            Tooltip.SetDefault("It doesn't allow you to ride wyverns, sorry\nMade by manzXja");
        }

        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 20;
            Item.rare = ItemRarityID.Cyan;
            Item.vanity = true;
            Item.accessory = true;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddTile(TileID.SkyMill)
                .AddIngredient(ItemID.Silk, 10)
                .AddIngredient(ItemID.Cloud, 5)
                .AddIngredient(ItemID.SoulofFlight, 3)
                .Register();
        }
    }
}
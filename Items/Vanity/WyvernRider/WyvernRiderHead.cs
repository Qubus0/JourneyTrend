using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.WyvernRider
{
    [AutoloadEquip(EquipType.Head)]
    public class WyvernRiderHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Wyvern Rider Hat");
            Tooltip.SetDefault("It doesn't allow you to ride wyverns, sorry\nMade by manzXja");
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Cyan;
            Item.vanity = true;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddTile(TileID.SkyMill)
                .AddIngredient(ItemID.Silk, 5)
                .AddIngredient(ItemID.Cloud, 2)
                .AddIngredient(ItemID.SoulofFlight, 2)
                .Register();
        }

        public override void DrawHair(ref bool drawHair, ref bool drawAltHair)
        {
            drawAltHair = true;
        }
    }
}
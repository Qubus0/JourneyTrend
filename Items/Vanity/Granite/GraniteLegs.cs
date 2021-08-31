using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Granite

{
    [AutoloadEquip(EquipType.Legs)]
    public class GraniteLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Granite Golem Legs");
            Tooltip.SetDefault("Made by EpicCrownKing");
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Blue;
            Item.vanity = true;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Granite, 15)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}
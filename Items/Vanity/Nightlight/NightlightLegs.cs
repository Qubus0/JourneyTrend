using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Nightlight
{
    [AutoloadEquip(EquipType.Legs)]
    public class NightlightLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            // DisplayName.SetDefault("Nightlight Feet");
            // Tooltip.SetDefault("No tripping at night with bug feet.\nMade by Metalsquirrel");
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Green;
            Item.vanity = true;
            Item.value = 0;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddTile(TileID.Loom)
                .AddIngredient(ItemID.Silk, 15)
                .AddIngredient(ItemID.Moonglow, 5)
                .Register();
        }
    }
}
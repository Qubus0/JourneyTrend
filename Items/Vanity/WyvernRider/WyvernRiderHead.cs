using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.WyvernRider
{
    [AutoloadEquip(EquipType.Head)]
    public class WyvernRiderHead : ModItem
    {
        public override void SetStaticDefaults()
        {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            // DisplayName.SetDefault("Wyvern Rider Hat");
            // Tooltip.SetDefault("It doesn't allow you to ride wyverns, sorry\nMade by manzXja");

            ArmorIDs.Head.Sets.DrawHatHair[Item.headSlot] = true;
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
    }
}
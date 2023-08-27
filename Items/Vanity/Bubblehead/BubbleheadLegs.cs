using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Bubblehead
{
    [AutoloadEquip(EquipType.Legs)]
    public class BubbleheadLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            // DisplayName.SetDefault("Carbon Boots");
            // Tooltip.SetDefault("Carbon has fantastic properties.\nMade by Metidigiti");
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
                .AddIngredient(ItemID.SoulofNight)
                .AddIngredient(ItemID.Diamond, 2)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }
    }
}
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Hivenet
{
    [AutoloadEquip(EquipType.Body)]
    public class HivenetBody : ModItem
    {
        public override void SetStaticDefaults()
        {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            DisplayName.SetDefault("HiveNet Chestplate");
            Tooltip.SetDefault("Not as Protective as it Looks.\nMade by Sam Holt");
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
                .AddIngredient(ItemID.BeeWax, 8)
                .AddIngredient(ItemID.Wire, 5)
                .Register();

            CreateRecipe()
                .AddTile(TileID.Anvils)
                .AddIngredient(ItemID.TinBar, 10)
                .AddIngredient(ItemID.BeeWax, 8)
                .AddIngredient(ItemID.Wire, 5)
                .Register();
        }
    }
}
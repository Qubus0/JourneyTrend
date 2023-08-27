using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Hivenet
{
    [AutoloadEquip(EquipType.Head)]
    public class HivenetHead : ModItem
    {
        public override void SetStaticDefaults()
        {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            // DisplayName.SetDefault("HiveNet Headset");
            // Tooltip.SetDefault("Listen to the Queen\nMade by Sam Holt");
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
                .AddIngredient(ItemID.CopperBar, 8)
                .AddIngredient(ItemID.BeeWax, 8)
                .AddIngredient(ItemID.Wire, 10)
                .Register();

            CreateRecipe()
                .AddTile(TileID.Anvils)
                .AddIngredient(ItemID.TinBar, 8)
                .AddIngredient(ItemID.BeeWax, 8)
                .AddIngredient(ItemID.Wire, 10)
                .Register();
        }
    }
}
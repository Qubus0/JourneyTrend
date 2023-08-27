using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.CrystalLegacy
{
    [AutoloadEquip(EquipType.Head)]
    public class CrystalLegacyHead : ModItem
    {
        public override void SetStaticDefaults()
        {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            // DisplayName.SetDefault("Crystal Helmet");
            /* Tooltip.SetDefault(
                "A memento of the dangers in the creeping crystal caves...\nMade by Curt 'Bucket Face' Black"); */
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Orange;
            Item.vanity = true;
            Item.value = 0;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.CrystalShard, 20)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}
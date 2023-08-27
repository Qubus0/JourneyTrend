using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.CrystalLegacy
{
    [AutoloadEquip(EquipType.Body)]
    public class CrystalLegacyBody : ModItem
    {
        public override void SetStaticDefaults()
        {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            // DisplayName.SetDefault("Crystal Torso");
            // Tooltip.SetDefault("The remnants of an overzealous adventurer...\nMade by Curt 'Bucket Face' Black");
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
                .AddIngredient(ItemID.CrystalShard, 25)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}
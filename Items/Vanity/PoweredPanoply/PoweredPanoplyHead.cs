using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.PoweredPanoply
{
    [AutoloadEquip(EquipType.Head)]
    public class PoweredPanoplyHead : ModItem
    {
        public override void SetStaticDefaults()
        {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            // DisplayName.SetDefault("Powered Armet");
            // Tooltip.SetDefault("'Three fourths and a fifth'\nMade by Fake_Tank");
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Blue;
            Item.vanity = true;
            Item.value = 0;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Nanites, 20)
                .AddRecipeGroup("JourneyTrend:SilverBars", 6)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}
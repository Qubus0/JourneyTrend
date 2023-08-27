using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Granite

{
    [AutoloadEquip(EquipType.Head)]
    public class GraniteHead : ModItem
    {
        public override void SetStaticDefaults()
        {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            // DisplayName.SetDefault("Granite Golem Greathelm");
            // Tooltip.SetDefault("Made by EpicCrownKing");
            
            ArmorIDs.Head.Sets.DrawHead[Item.headSlot] = false;
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
                .AddIngredient(ItemID.Granite, 20)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}
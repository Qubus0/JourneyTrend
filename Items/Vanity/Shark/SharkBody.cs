using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Shark

{
    [AutoloadEquip(EquipType.Body)]
    public class SharkBody : ModItem
    {
        public override void SetStaticDefaults()
        {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            // DisplayName.SetDefault("Shark Shirt");
            // Tooltip.SetDefault("An inflated shark costume.\nThose fins are moving on their own!\nMade by Giobun");
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Blue;
            Item.vanity = true;
            Item.value = 0;
        }
    }
}
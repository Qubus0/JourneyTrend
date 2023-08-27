using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Kingfisher
{
    [AutoloadEquip(EquipType.Head)]
    public class KingfisherHead : ModItem
    {
        public override void SetStaticDefaults()
        {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            // DisplayName.SetDefault("Common Kingfisher Mask");
            /* Tooltip.SetDefault(
                "The kingfisher rises out of the black wave like a blue flower.\nIn his beak, he carries a silver leaf.\nAlcedo atthis Approved!\nMade by Squidcrane"); */

            ArmorIDs.Head.Sets.DrawHead[Item.headSlot] = false;
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
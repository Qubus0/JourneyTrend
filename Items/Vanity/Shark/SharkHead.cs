using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Shark

{
    [AutoloadEquip(EquipType.Head)]
    public class SharkHead : ModItem
    {
        public override void SetStaticDefaults()
        {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            // DisplayName.SetDefault("Shark Mask");
            // Tooltip.SetDefault("An inflated shark mask.\nDoes not let you breathe underwater.\nMade by Giobun");

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
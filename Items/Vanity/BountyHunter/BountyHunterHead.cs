using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.BountyHunter
{
    [AutoloadEquip(EquipType.Head)]
    public class BountyHunterHead : ModItem
    {
        public override void SetStaticDefaults()
        {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            DisplayName.SetDefault("Bounty Hunter Mask");
            Tooltip.SetDefault(
                "A high-tech battle armour developed by Dr. Tobopolis.\nSome Accidental Disintegrations.\nMade by Tobopolis");

            ArmorIDs.Head.Sets.DrawHead[Item.headSlot] = false;
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Yellow;
            Item.vanity = true;
            Item.value = 50000; //only if sold.
        }
    }
}
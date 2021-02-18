using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Bounty
{
    [AutoloadEquip(EquipType.Head)]
    public class BountyHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bounty Hunter Mask");
            Tooltip.SetDefault(
                "A high-tech battle armour developed by Dr. Tobopolis.\nSome Accidental Disintegrations.\nMade by Tobopolis");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Yellow;
            item.vanity = true;
            item.value = 50000; //only if sold.
        }

        public override bool DrawHead()
        {
            return false;
        }
    }
}
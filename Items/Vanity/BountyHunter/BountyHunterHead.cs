using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.BountyHunter
{
    [AutoloadEquip(EquipType.Head)]
    public class BountyHunterHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bounty Hunter Mask");
            Tooltip.SetDefault(
                "A high-tech battle armour developed by Dr. Tobopolis.\nSome Accidental Disintegrations.\nMade by Tobopolis");
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Yellow;
            Item.vanity = true;
            Item.value = 50000; //only if sold.
        }

        public override bool DrawHead()
        {
            return false;
        }
    }
}
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Bounty
{
    [AutoloadEquip(EquipType.Legs)]
    public class BountyLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bounty Hunter Greaves");
            Tooltip.SetDefault(
                "A high-tech battle armour developed by Dr. Tobopolis.\nIt's strictly business.\nMade by Tobopolis");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Yellow;
            item.vanity = true;
            item.value = 50000; //only if sold.
        }
    }
}
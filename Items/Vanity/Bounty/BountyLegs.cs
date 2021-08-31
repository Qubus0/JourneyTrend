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
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Yellow;
            Item.vanity = true;
            Item.value = 50000; //only if sold.
        }
    }
}
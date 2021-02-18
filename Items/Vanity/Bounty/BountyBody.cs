using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Bounty
{
    [AutoloadEquip(EquipType.Body)]
    public class BountyBody : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bounty Hunter Chestplate");
            Tooltip.SetDefault(
                "A high-tech battle armour developed by Dr. Tobopolis.\nWatch out for space dragons!\nMade by Tobopolis");
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
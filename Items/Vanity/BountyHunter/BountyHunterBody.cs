using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.BountyHunter
{
    [AutoloadEquip(EquipType.Body)]
    public class BountyHunterBody : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bounty Hunter Chestplate");
            Tooltip.SetDefault(
                "A high-tech battle armour developed by Dr. Tobopolis.\nWatch out for space dragons!\nMade by Tobopolis");
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
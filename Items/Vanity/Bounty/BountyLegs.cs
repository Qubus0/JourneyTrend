using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyTrend.Items.Vanity.Bounty
{
    [AutoloadEquip(EquipType.Legs)]
    public class BountyLegs : ModItem
    {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Bounty Hunter Greaves");
            Tooltip.SetDefault("A high-tech battle armour developed by Dr. Tobopolis.\nMade by Tobopolis");
        }
        
        public override void SetDefaults() {
            item.width = 18;
            item.height = 18;
            item.rare = 8;
            item.vanity = true;
            item.value = 50000;                             //only if sold.
        }
    }
}

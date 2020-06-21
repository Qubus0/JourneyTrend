using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Shootsaton
{
    [AutoloadEquip(EquipType.Head)]
    public class ShootsatonHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sire Shootsaton Hooten Mask");
            Tooltip.SetDefault("I love havin' an owl head\nMade by Enembra");
        }
        
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Blue;
            item.vanity = true;
        }
    }
}


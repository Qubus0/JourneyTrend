using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Shootsaton
{
    [AutoloadEquip(EquipType.Legs)]
    public class ShootsatonLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sire Shootsaton Pants");
            Tooltip.SetDefault("Take aim of your talons in the dark.\nMade by Enembra");
        }
        
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = 1;
            item.vanity = true;
        }
    }
}
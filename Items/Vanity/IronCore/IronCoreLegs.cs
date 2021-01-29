using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyTrend.Items.Vanity.IronCore
{
    [AutoloadEquip(EquipType.Legs)]
    public class IronCoreLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Greaves of the Iron Core");
            Tooltip.SetDefault("Some ruined leggings from a long gone warrior.\nLegends say that you can hold a mountain up while wearing them. They're wrong.\nMade by TunaToda & RealStiel");
        }
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Blue;
            item.vanity = true;
            item.value = 0;
        }
    }
}
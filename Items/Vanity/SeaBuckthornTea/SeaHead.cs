using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyTrend.Items.Vanity.SeaBuckthornTea
{
    [AutoloadEquip(EquipType.Head)]
    public class SeaHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("A Cup of Tea");
            Tooltip.SetDefault("It smells like Sea Buckthorn Tea!\nMade by VaeloroK");
        }
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = 1;
            item.vanity = true;
            item.value = 250000;
        }
        public override bool DrawHead()
        {
            return false;
        }
    }
}
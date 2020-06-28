using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyTrend.Items.Vanity.Pilot
{
    [AutoloadEquip(EquipType.Head)]
    public class PilotHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pilot's Cap");
            Tooltip.SetDefault("Still some wyvern saliva in the goggles,\nbut otherwise surprisingly intact.\nMade by CyrantontheCold");
        }
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.LightRed;
            item.vanity = true;
        }
    }
}
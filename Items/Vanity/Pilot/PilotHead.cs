using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Pilot
{
    [AutoloadEquip(EquipType.Head)]
    public class PilotHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pilot's Cap");
            Tooltip.SetDefault(
                "Still some wyvern saliva in the goggles,\nbut otherwise surprisingly intact.\nMade by CyrantontheCold");
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.LightRed;
            Item.vanity = true;
        }
    }
}
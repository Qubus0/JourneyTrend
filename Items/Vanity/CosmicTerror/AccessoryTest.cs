using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyTrend.Items.Vanity.CosmicTerror
{
    [AutoloadEquip(EquipType.Balloon)]
    public class AccessoryTest : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Accessory Test");
            Tooltip.SetDefault("Accessory Test Tooltip");
        }
        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 24;
            item.rare = 1;
            item.accessory = true;
            item.vanity = true;
        }
    }
}
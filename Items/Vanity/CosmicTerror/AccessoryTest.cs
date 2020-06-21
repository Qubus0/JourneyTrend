using Terraria.ID;
using Terraria.ModLoader;

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
            item.rare = ItemRarityID.Blue;
            item.accessory = true;
            item.vanity = true;
        }
    }
}
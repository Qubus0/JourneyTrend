using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyTrend.Items.Vanity.AndromedaPilot
{
    [AutoloadEquip(EquipType.Legs)]
    public class AndromedaPilotLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cetus");
            Tooltip.SetDefault("Those chains really don't suit you\nMade by Nedrilax");
        }
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Lime;
            item.vanity = true;
        }
    }
}
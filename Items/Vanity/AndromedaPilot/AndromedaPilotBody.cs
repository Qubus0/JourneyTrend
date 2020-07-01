using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyTrend.Items.Vanity.AndromedaPilot
{
    [AutoloadEquip(EquipType.Body)]
    public class AndromedaPilotBody : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Andromeda Pilot Breastplate");
            Tooltip.SetDefault("Let there be a constellation with your name on it\nMade by Nedrilax");
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
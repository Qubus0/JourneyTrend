using Terraria.ID;
using Terraria.ModLoader;

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
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Lime;
            Item.vanity = true;
        }
    }
}
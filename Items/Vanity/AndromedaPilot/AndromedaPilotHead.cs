using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.AndromedaPilot
{
    [AutoloadEquip(EquipType.Head)]
    public class AndromedaPilotHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Andromeda Pilot Helmet");
            Tooltip.SetDefault("Let there be a constellation with your name on it\nMade by Nedrilax");
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Lime;
            Item.vanity = true;
        }

        public override bool DrawHead()
        {
            return false;
        }
    }
}
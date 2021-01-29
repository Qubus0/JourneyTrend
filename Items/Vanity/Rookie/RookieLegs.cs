using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Rookie

{
    [AutoloadEquip(EquipType.Legs)]
    public class RookieLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rookie Base");
            Tooltip.SetDefault("Stay Grounded\nMade by PeanutSte");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Blue;
            item.vanity = true;
            item.value = 0;
        }

        public override bool DrawLegs()
        {
            return false;
        }
    }
}
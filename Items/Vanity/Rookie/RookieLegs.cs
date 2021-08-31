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
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Blue;
            Item.vanity = true;
            Item.value = 0;
        }

        public override bool DrawLegs()
        {
            return false;
        }
    }
}
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.RookieSet
{
    [AutoloadEquip(EquipType.Head)]
    public class RookieHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rookie Steepletop");
            Tooltip.SetDefault("Created by an aspiring artist\nMade by PeanutSte");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Blue;
            item.vanity = true;
        }

        public override bool DrawHead()
        {
            return false;
        }
    }
}
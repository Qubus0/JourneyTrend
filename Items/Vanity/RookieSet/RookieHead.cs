using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyTrend.Items.Vanity.RookieSet
{
    [AutoloadEquip(EquipType.Head)]
    public class RookieHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rookie Steepletop");
            Tooltip.SetDefault("Made by an aspiring artist. \nCreated by Ste");
        }
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = 1;
            item.vanity = true;
        }
        public override bool DrawHead()
        {
            return false;
        }
    }
}
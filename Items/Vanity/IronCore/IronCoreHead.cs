using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyTrend.Items.Vanity.IronCore
{
    [AutoloadEquip(EquipType.Head)]
    public class IronCoreHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Helmet of the Iron Core");
            Tooltip.SetDefault("A rusty iron helmet from a knight long dead.\nIt's heavy, cold, and not very helpful.\nMade by RealStiel");
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
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.IronCore
{
    [AutoloadEquip(EquipType.Head)]
    public class IronCoreHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Helmet of the Iron Core");
            Tooltip.SetDefault("A rusty iron helmet from a knight long dead.\nIt's heavy, cold, and not very helpful.\nMade by TunaToda & RealStiel");
        }
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Blue;
            item.vanity = true;
            item.value = 0;
        }
        public override bool DrawHead()
        {
            return false;
        }
    }
}
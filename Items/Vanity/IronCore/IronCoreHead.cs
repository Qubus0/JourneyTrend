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
            Tooltip.SetDefault(
                "A rusty iron helmet from a knight long dead.\nIt's heavy, cold, and not very helpful.\nMade by TunaToda & RealStiel");
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Blue;
            Item.vanity = true;
            Item.value = 0;
        }

        public override bool DrawHead()
        {
            return false;
        }
    }
}
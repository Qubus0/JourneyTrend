using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyTrend.Items.Vanity.Mothron
{
    [AutoloadEquip(EquipType.Head)]
    public class MothronMask : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mothron Mask");
            Tooltip.SetDefault("A mask born in the dim light of a solar eclipse. \nCreated by Drdragonfly");
        }
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = 1;
            item.vanity = true;
        }
        // public override bool DrawHead()
        // {
        //     return false;
        // }
    }
}
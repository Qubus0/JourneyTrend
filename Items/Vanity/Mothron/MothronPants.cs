using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyTrend.Items.Vanity.Mothron
{
    [AutoloadEquip(EquipType.Legs)]
    public class MothronPants : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Mothron Pants");
            Tooltip.SetDefault("The pattern resembles that of Mothron's abdomen. \nCreated by Drdragonfly");
        }
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = 1;
            item.vanity = true;
        }
        // public override bool DrawLegs()
        // {
        //     return false;
        // }
    }
}
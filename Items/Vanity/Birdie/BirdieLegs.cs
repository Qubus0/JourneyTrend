using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Birdie
{
    [AutoloadEquip(EquipType.Legs)]
    public class BirdieLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Birdie Pants");
            Tooltip.SetDefault("By spreading your legs a little, you can nail a pretty decent shot!\nMade by Pyromma");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.LightRed;
            item.vanity = true;
            item.value = 50000;
        }
    }
}
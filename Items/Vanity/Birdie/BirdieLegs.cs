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
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.LightRed;
            Item.vanity = true;
            Item.value = 50000;
        }
    }
}
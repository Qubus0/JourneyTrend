using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.NineTailedFox
{
    [AutoloadEquip(EquipType.Legs)]
    public class NineTailedFoxLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nine-Tailed Fox Leggings");
            Tooltip.SetDefault("Made by Invalid");
        }

        public override void SetDefaults()
        {
            Item.vanity = true;
            Item.value = 50000;
            Item.rare = ItemRarityID.Lime;
        }

        public override bool DrawLegs()
        {
            return false;
        }
    }
}
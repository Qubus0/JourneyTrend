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
        }

        public override void SetDefaults()
        {
            item.vanity = true;
            item.value = 50000;
            item.rare = ItemRarityID.Lime;
        }

        public override bool DrawLegs()
        {
            return false;
        }
    }
}
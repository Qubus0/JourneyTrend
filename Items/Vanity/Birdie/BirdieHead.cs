using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyTrend.Items.Vanity.Birdie
{
    [AutoloadEquip(EquipType.Head)]
    public class BirdieHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Birdie Headgear");
            Tooltip.SetDefault("Go ahead, dominate this golf course!\nMade by Pyromma");
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
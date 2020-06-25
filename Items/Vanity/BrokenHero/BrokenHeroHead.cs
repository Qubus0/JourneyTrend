using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.BrokenHero
{
    [AutoloadEquip(EquipType.Head)]
    public class BrokenHeroHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Broken Hero Helmet");
            Tooltip.SetDefault("Smells of rust and mold\nMade by Kirichin");
        }
        
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.LightRed;
            item.vanity = true;
        }
    }
}
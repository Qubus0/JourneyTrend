using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.BrokenHero
{
    [AutoloadEquip(EquipType.Body)]
    public class BrokenHeroBody : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Broken Hero Chestplate");
            Tooltip.SetDefault("The broken edges scratch your skin\nMade by Kirichin");
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
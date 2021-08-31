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
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.LightRed;
            Item.vanity = true;
        }
    }
}
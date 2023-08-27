using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.BrokenHero
{
    [AutoloadEquip(EquipType.Legs)]
    public class BrokenHeroLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            // DisplayName.SetDefault("Broken Hero Greaves");
            // Tooltip.SetDefault("Eerily fits you perfectly\nMade by Kirichin");
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
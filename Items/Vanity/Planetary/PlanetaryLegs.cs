using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Planetary
{
    [AutoloadEquip(EquipType.Legs)]
    public class PlanetaryLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            // DisplayName.SetDefault("Planetary Pants");
            // Tooltip.SetDefault("Made by Goddigger3_1");
        }
        
        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Blue;
            Item.vanity = true;
        }
    }
}
using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyTrend.Items.Vanity.MushroomAlchemist
{
    [AutoloadEquip(EquipType.Legs)]
    public class MushroomAlchemistLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mushroom Alchemist Pants");
            Tooltip.SetDefault("Feels like magic.\nMade by Galahad");
        }
        
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Blue;
            item.vanity = true;
            item.value = 200000;                             //only if sold.
        }
    }
}
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.MushroomAlchemist
{
    [AutoloadEquip(EquipType.Head)]
    public class MushroomAlchemistHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mushroom Alchemist Cap");
            Tooltip.SetDefault("Everything is blue.\nMade by Galahad");
        }
        
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = 1;
            item.vanity = true;
            item.value = 200000;                             //only if sold.
        }
    }
}


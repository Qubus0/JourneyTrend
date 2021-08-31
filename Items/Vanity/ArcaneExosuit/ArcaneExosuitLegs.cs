using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.ArcaneExosuit
{
    [AutoloadEquip(EquipType.Legs)]
    public class ArcaneExosuitLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Arcane Exosuit Femora");
            Tooltip.SetDefault(
                "The armor shines a dull gold that could be enhanced with a solar coating\nMade by Faskeon");
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Blue;
            Item.vanity = true;
            Item.value = 50000;
        }
    }
}
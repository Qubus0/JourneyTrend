using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.SwampHorror
{
    [AutoloadEquip(EquipType.Legs)]
    public class SwampHorrorLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Swamp Horror Pants");
            Tooltip.SetDefault("Made by Outerwar");
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
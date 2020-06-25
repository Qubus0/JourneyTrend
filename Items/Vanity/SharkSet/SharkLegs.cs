using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.SharkSet
{
    [AutoloadEquip(EquipType.Legs)]
    public class SharkLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Shark Pants");
            Tooltip.SetDefault("A pair of inflated shark pants.\nJust go with the flow.\nMade by Giobun");
        }
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Blue;
            item.vanity = true;
        }
    }
}
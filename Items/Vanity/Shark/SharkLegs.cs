using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Shark

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
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Blue;
            Item.vanity = true;
            Item.value = 0;
        }
    }
}
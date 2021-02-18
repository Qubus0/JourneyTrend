using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.WitchsVoid
{
    [AutoloadEquip(EquipType.Legs)]
    public class WitchsVoidLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Void's Boots");
            Tooltip.SetDefault("The numbers '2416' are etched on each piece...how strange.\nMade by Hexanne");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Pink;
            item.vanity = true;
        }
    }
}
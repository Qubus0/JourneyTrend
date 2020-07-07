using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Knightwalker
{
    [AutoloadEquip(EquipType.Legs)]
    public class KnightwalkerLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Greaves of the Knightwalker");
            Tooltip.SetDefault("Made by Dusk Ealain");
        }
        
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Purple;
            item.vanity = true;
        }
    }
}
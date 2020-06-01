using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyTrend.Items.Vanity.SwampHorror
{
    [AutoloadEquip(EquipType.Legs)]
    public class SwampHorrorLegs : ModItem
    {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Swamp Horror Pants");
            Tooltip.SetDefault("Made by Outerwar");
        }
        
        public override void SetDefaults() {
            item.width = 18;
            item.height = 18;
            item.rare = 1;
            item.vanity = true;
        }
    }
}

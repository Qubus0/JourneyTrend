using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyTrend.Items.Vanity.SwampHorror
{
    [AutoloadEquip(EquipType.Body)]
    public class SwampHorrorBody : ModItem
    {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Swamp Horror Shirt");
            Tooltip.SetDefault("Made by Outerwar");
        }
        
        public override void SetDefaults() {
            item.width = 18;
            item.height = 18;
            item.rare = 1;
            item.vanity = true;
        }

        public override bool DrawBody() {
            return false;
        }
    }
}
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyTrend.Items.Vanity.CyberAngel
{
    [AutoloadEquip(EquipType.Body)]
    public class CyberAngelBody : ModItem
    {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Cyber Coat");
            Tooltip.SetDefault("The energy is used to purify the corruption and the crimson of the world.\nMade by Rariaz");
        }
        
        public override void SetDefaults() {
            item.width = 18;
            item.height = 18;
            item.rare = 9;
            item.vanity = true;
            item.value = 250000;                             //only if sold.
        }
        
        public override void DrawHands(ref bool drawHands, ref bool drawArms) {
            drawHands = true;
        }
    }
}

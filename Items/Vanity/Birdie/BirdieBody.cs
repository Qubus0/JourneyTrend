using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyTrend.Items.Vanity.Birdie
{
    [AutoloadEquip(EquipType.Body)]
    public class BirdieBody : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Birdie Sweater");
            Tooltip.SetDefault("It's not stylish anymore...\nMade by Pyromma.");
        }
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = 4;
            item.vanity = true;
            item.value = 50000;
        }
        public override void DrawHands(ref bool drawHands, ref bool drawArms) {
            drawHands = true;
        }
    }
}
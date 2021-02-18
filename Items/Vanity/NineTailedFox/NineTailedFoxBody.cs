using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.NineTailedFox
{
    [AutoloadEquip(EquipType.Body)]
    public class NineTailedFoxBody : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nine-Tailed Fox Chestplate");
        }

        public override void SetDefaults()
        {
            item.vanity = true;
            item.value = 50000;
            item.rare = ItemRarityID.Lime;
        }

        public override void DrawHands(ref bool drawHands, ref bool drawArms)
        {
            drawHands = true;
            drawArms = true;
        }
    }
}
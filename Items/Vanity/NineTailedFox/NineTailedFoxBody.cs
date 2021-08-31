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
            Tooltip.SetDefault("Made by Invalid");
        }

        public override void SetDefaults()
        {
            Item.vanity = true;
            Item.value = 50000;
            Item.rare = ItemRarityID.Lime;
        }

        public override void DrawHands(ref bool drawHands, ref bool drawArms)
        {
            drawHands = true;
            drawArms = true;
        }
    }
}
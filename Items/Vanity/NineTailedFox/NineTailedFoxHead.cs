using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.NineTailedFox
{
    [AutoloadEquip(EquipType.Head)]
    public class NineTailedFoxHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nine-Tailed Fox Ears");
            Tooltip.SetDefault("Made by Invalid");
        }

        public override void SetDefaults()
        {
            Item.vanity = true;
            Item.value = 50000;
            Item.rare = ItemRarityID.Lime;
        }

        public override void DrawHair(ref bool drawHair, ref bool drawAltHair)
        {
            drawHair = true;
            drawAltHair = false;
        }
    }
}
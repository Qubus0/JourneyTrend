using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.CyberAngel
{
    [AutoloadEquip(EquipType.Body)]
    public class CyberAngelBody : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cyber Coat");
            Tooltip.SetDefault(
                "The energy is used to purify the corruption and the crimson of the world.\nMade by Rariaz");
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Cyan;
            Item.vanity = true;
            Item.value = 250000; //only if sold.
        }

        public override void DrawHands(ref bool drawHands, ref bool drawArms)
        {
            drawHands = true;
        }
    }
}
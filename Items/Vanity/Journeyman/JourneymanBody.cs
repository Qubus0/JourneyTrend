using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Journeyman
{
    [AutoloadEquip(EquipType.Body)]
    public class JourneymanBody : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Journeyman Shirt");
            Tooltip.SetDefault("A fancy jacket worn by journeymen.\nMade by poiuygfd");
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.value = 150000;
            Item.rare = ItemRarityID.Gray;
            Item.vanity = true;
        }

        public override bool? CanBurnInLava()
        {
            return false;
        }

        public override void DrawHands(ref bool drawHands, ref bool drawArms)
        {
            drawHands = true;
        }
    }
}
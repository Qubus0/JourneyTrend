using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.WitchsVoid
{
    [AutoloadEquip(EquipType.Body)]
    public class WitchsVoidBody : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Void's Cloak");
            Tooltip.SetDefault("The numbers '2416' are etched on each piece...how strange.\nMade by Hexanne");
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Pink;
            Item.vanity = true;
        }

        public override void DrawHands(ref bool drawHands, ref bool drawArms)
        {
            drawHands = true;
        }
    }
}
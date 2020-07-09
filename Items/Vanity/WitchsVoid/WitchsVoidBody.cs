using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.WitchsVoid
{
    [AutoloadEquip(EquipType.Body)]
    public class WitchsVoidBody : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Void Robe");
            Tooltip.SetDefault("It radiates pure evil\nMade by Hexanne");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Pink;
            item.vanity = true;
        }

        public override void DrawHands(ref bool drawHands, ref bool drawArms)
        {
            drawHands = true;
        }
    }
}
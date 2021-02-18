using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Terra
{
    [AutoloadEquip(EquipType.Legs)]
    public class TerraLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Terra Leggings");
            Tooltip.SetDefault(
                "Powers from the edge of nights and the light of new days\nMay this armor help you reach the journey's end\nMade by TerraKingCole614");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Lime;
            item.vanity = true;
        }
    }
}
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyTrend.Items.Vanity.CosmicTerror
{
    [AutoloadEquip(EquipType.Body)]
    public class CosmicTerrorBody : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cosmic Terror's Body");
            Tooltip.SetDefault("But he is not the only one;\n there is another cosmic being but him in this world.\nThe destroyer of worlds, the Moon Lord.\nMade by RegMeow.");
        }
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = 1;
            item.vanity = true;
        }
    }
}
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.CosmicTerror
{
    [AutoloadEquip(EquipType.Body)]
    public class CosmicTerrorBody : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cosmic Terror's Body");
            Tooltip.SetDefault(
                "But he is not the only one;\n there is another cosmic being but him in this world.\nThe destroyer of worlds, the Moon Lord.\nMade by RegMeow");
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Blue;
            Item.vanity = true;
            Item.value = 0;
        }
    }
}
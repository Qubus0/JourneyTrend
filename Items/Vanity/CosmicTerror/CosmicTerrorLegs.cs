using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.CosmicTerror
{
    [AutoloadEquip(EquipType.Legs)]
    public class CosmicTerrorLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cosmic Terror's Legs");
            Tooltip.SetDefault("His body badly hurt from the endless battle with the Lunar God, it will finally come to an end.\nSoon he might succumb to his wounds, so use his form to face \"Moon Lord\" once more.\nMade by RegMeow");
        }
        public override void SetDefaults()  
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Blue;
            item.vanity = true;
        }
    }
}
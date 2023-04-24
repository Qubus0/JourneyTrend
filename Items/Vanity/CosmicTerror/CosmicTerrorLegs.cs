using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.CosmicTerror
{
    [AutoloadEquip(EquipType.Legs)]
    public class CosmicTerrorLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            DisplayName.SetDefault("Cosmic Terror's Legs");
            Tooltip.SetDefault(
                "His body badly hurt from the endless battle with the Lunar God, it will finally come to an end.\nSoon he might succumb to his wounds, so use his form to face \"Moon Lord\" once more.\nMade by RegMeow");
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
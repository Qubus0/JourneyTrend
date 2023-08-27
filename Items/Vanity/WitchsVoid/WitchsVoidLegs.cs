using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.WitchsVoid
{
    [AutoloadEquip(EquipType.Legs)]
    public class WitchsVoidLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            // DisplayName.SetDefault("Void's Boots");
            // Tooltip.SetDefault("The numbers '2416' are etched on each piece...how strange.\nMade by Hexanne");
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Pink;
            Item.vanity = true;
        }
    }
}
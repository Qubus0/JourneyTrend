using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Journeyman
{
    [AutoloadEquip(EquipType.Body)]
    public class JourneymanBody : ModItem
    {
        public override void SetStaticDefaults()
        {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            ItemID.Sets.IsLavaImmuneRegardlessOfRarity[Item.type] = true;

            // DisplayName.SetDefault("Journeyman Shirt");
            // Tooltip.SetDefault("A fancy jacket worn by journeymen.\nMade by poiuygfd");

            ArmorIDs.Body.Sets.HidesHands[Item.bodySlot] = false;
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.value = 150000;
            Item.rare = ItemRarityID.Gray;
            Item.vanity = true;
        }
    }
}
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.CyberAngel
{
    [AutoloadEquip(EquipType.Legs)]
    public class CyberAngelLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            // DisplayName.SetDefault("Cyber Leggings");
            /* Tooltip.SetDefault(
                "Some dare to use this armor, but just a few can bear the fatigue,\nonly those who achieve power, wisdom, nimbleness,\nand kindness are worthy to try this armor.\nMade by Rariaz"); */
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Cyan;
            Item.vanity = true;
            Item.value = 250000; //only if sold.
        }
    }
}
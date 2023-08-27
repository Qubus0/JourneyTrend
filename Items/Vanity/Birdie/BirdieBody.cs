using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Birdie
{
    [AutoloadEquip(EquipType.Body)]
    public class BirdieBody : ModItem
    {
        public override void SetStaticDefaults()
        {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            // DisplayName.SetDefault("Birdie Sweater");
            // Tooltip.SetDefault("It's not stylish anymore...\nMade by Pyromma");

            ArmorIDs.Body.Sets.HidesArms[Item.bodySlot] = false;
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.LightRed;
            Item.vanity = true;
            Item.value = 50000;
        }
    }
}
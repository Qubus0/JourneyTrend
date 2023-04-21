using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.NineTailedFox
{
    [AutoloadEquip(EquipType.Legs)]
    public class NineTailedFoxLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            DisplayName.SetDefault("Nine-Tailed Fox Leggings");
            Tooltip.SetDefault("Made by Invalid");

            ArmorIDs.Legs.Sets.OverridesLegs[Item.legSlot] = true;
        }

        public override void SetDefaults()
        {
            Item.vanity = true;
            Item.value = 50000;
            Item.rare = ItemRarityID.Lime;
        }
    }
}
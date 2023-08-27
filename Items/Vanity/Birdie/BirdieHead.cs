using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Birdie
{
    [AutoloadEquip(EquipType.Head)]
    public class BirdieHead : ModItem
    {
        public override void SetStaticDefaults()
        {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            // DisplayName.SetDefault("Birdie Headgear");
            // Tooltip.SetDefault("Go ahead, dominate this golf course!\nMade by Pyromma");
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
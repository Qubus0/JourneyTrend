using Terraria.GameContent.Creative;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.NineTailedFox
{
    [AutoloadEquip(EquipType.Wings)]
    public class NineTailedFoxAcc : ModItem
    {
        public override void SetStaticDefaults()
        {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            // DisplayName.SetDefault("Nine-Tailed Fox Tails");
            // Tooltip.SetDefault("Why does the inventory sprite only show 7 tails? Is this a scam?\nMade by Invalid");
        }

        public override void SetDefaults()
        {
            Item.accessory = true;
            Item.vanity = true;
            Item.value = 50000;
            Item.rare = ItemRarityID.Lime;
        }

        public override void EquipFrameEffects(Player player, EquipType type)
        {
            player.GetModPlayer<JourneyPlayer>().NineTailedFoxAccBackEquipped = true;
        }
    }
}
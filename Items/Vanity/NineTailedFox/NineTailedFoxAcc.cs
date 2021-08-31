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
            DisplayName.SetDefault("Nine-Tailed Fox Tails");
            Tooltip.SetDefault("Why does the inventory sprite only show 7 tails? Is this a scam?\nMade by Invalid");
        }

        public override void SetDefaults()
        {
            Item.accessory = true;
            Item.vanity = true;
            Item.value = 50000;
            Item.rare = ItemRarityID.Lime;
        }

        public override bool WingUpdate(Player player, bool inUse)
        {
            if (inUse) player.GetModPlayer<JourneyPlayer>().NinetailedFlying = true;
            return false;
        }

        public override void UpdateVanity(Player player)
        {
            player.GetModPlayer<JourneyPlayer>().FoxTailsEquipped = true;
        }
    }
}
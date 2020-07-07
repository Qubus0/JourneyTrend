using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Rookie

{
    [AutoloadEquip(EquipType.Body)]
    public class RookieBody : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rookie Body");
            Tooltip.SetDefault("Life is never just black and white\nMade by PeanutSte");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Blue;
            item.vanity = true;
        }

        public override bool DrawBody()
        {
            return false;
        }

        public override void UpdateVanity(Player player, EquipType type)
        {
            player.GetModPlayer<JourneyPlayer>().doOffset = true;
        }
    }
}
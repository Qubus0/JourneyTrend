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
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Blue;
            Item.vanity = true;
            Item.value = 0;
        }

        public override bool DrawBody()
        {
            return false;
        }

        public override void UpdateVanity(Player player)
        {
            player.GetModPlayer<JourneyPlayer>().doOffset = true;
        }
    }
}
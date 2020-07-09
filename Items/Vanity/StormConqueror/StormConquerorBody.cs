using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;


namespace JourneyTrend.Items.Vanity.StormConqueror
{
    [AutoloadEquip(EquipType.Body)]
    public class StormConquerorBody : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Storm Conqueror's Breastplate");
            Tooltip.SetDefault("Ouch, it zapped me!\nMade by Dandandooo");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Cyan;
            item.vanity = true;
        }

        public override void UpdateVanity(Player player, EquipType type)
        {
            if (player.velocity != Vector2.Zero && Main.rand.NextFloat() < 0.2f)
            {
                Dust.NewDust(player.Center - new Vector2(player.direction*10 + 5, 20), 10, 40, DustType<StormConquerorDust>());
            }
        }
    }
}
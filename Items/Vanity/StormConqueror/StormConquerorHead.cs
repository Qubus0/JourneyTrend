using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyTrend.Items.Vanity.StormConqueror
{
    [AutoloadEquip(EquipType.Head)]
    public class StormConquerorHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Storm Conqueror's Visage");
            Tooltip.SetDefault("Wow, so shiny!\nMade by Dandandooo");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Cyan;
            item.vanity = true;
            item.value = 0;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ItemType<StormConquerorBody>() && legs.type == ItemType<StormConquerorLegs>();
        }

        public override void UpdateVanitySet(Player player)
        {
            if (player.velocity != Vector2.Zero && Main.rand.NextFloat() < 0.2f)
                Dust.NewDust(player.Center - new Vector2(player.direction * 10 + 5, 20), 10, 40,
                    DustType<StormConquerorDust>());
        }
    }
}
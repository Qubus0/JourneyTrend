using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.StarlightDream
{
    [AutoloadEquip(EquipType.Body)]
    public class StarlightDreamBody : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Starlight Dream Shirt");
            Tooltip.SetDefault("Made by Golditale");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Cyan;
            item.vanity = true;
        }

        public override void DrawHands(ref bool drawHands, ref bool drawArms)
        {
            drawHands = true;
        }

        private readonly float adj = 0.00392f / 2; //adjusts the rgb value from 0-255 to 0-1 (/2)
        public override void UpdateVanity(Player player, EquipType type)
        {
            player.GetModPlayer<JourneyPlayer>().StarlightBodyEquipped = true;
            Lighting.AddLight(player.Center, 241 * adj, 215 * adj, 108 * adj);

        }
    }
}
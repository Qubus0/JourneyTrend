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
            DisplayName.SetDefault("Set");
            Tooltip.SetDefault("Tooltip\nMade by Golditale");
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

        public override void UpdateVanity(Player player, EquipType type)
        {
            player.GetModPlayer<JourneyPlayer>().StarlightBodyEquipped = true;
        }
    }
}
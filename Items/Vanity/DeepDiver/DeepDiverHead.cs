using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.DeepDiver
{
    [AutoloadEquip(EquipType.Head)]
    public class DeepDiverHead : ModItem
    {
        private readonly float adj = 0.00392f / 2; //adjusts the rgb value from 0-255 to 0-1 (/3)

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Deep Diver Hood");
            Tooltip.SetDefault("Creepy, stylish and it also glows!\nMade by Nick T.");
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Blue;
            Item.vanity = true;
            Item.value = 100000; //only if sold.
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            foreach (var line2 in tooltips)
                if (line2.Mod == "Terraria" && line2.Name == "ItemName")
                    line2.OverrideColor = new Color(15, 4, 68);
        }

        public override void EquipFrameEffects(Player player, EquipType type)
        {
            Lighting.AddLight(player.Center, 226 * adj, 255 * adj, 88 * adj);
        }
    }
}
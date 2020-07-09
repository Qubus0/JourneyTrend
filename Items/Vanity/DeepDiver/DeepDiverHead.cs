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
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Deep Diver Hood");
            Tooltip.SetDefault("Creepy, stylish and it also glows!\nMade by Nick T.");
        }
        
        public override void SetDefaults() {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Blue;
            item.vanity = true;
            item.value = 100000;                             //only if sold.
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips) {
            foreach (TooltipLine line2 in tooltips) {
                if (line2.mod == "Terraria" && line2.Name == "ItemName") {
                    line2.overrideColor = new Color(15, 4, 68);
                }
           }
        }

        private readonly float adj = 0.00392f / 2; //adjusts the rgb value from 0-255 to 0-1 (/3)
        public override void UpdateVanity(Player player, EquipType type)
        {
            Lighting.AddLight(player.Center, 226 * adj, 255 * adj, 88 * adj);
        }
    }
}

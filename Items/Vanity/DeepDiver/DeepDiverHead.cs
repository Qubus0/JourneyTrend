using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using System.Collections.Generic;

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
            item.rare = 1;
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
    }
}

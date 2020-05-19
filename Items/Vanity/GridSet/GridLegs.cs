using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace JourneyTrend.Items.Vanity.GridSet
{
    [AutoloadEquip(EquipType.Legs)]
    public class GridLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Grid's Footgear");
            Tooltip.SetDefault("A legendary piece of armor.\nCrafted by Grid.");
        }
        public override void ModifyTooltips(List<TooltipLine> tooltips) {
            foreach (TooltipLine line2 in tooltips) {
                if (line2.mod == "Terraria" && line2.Name == "ItemName") {
                    line2.overrideColor = new Color(85, 0, 0);
                }
            }
        }
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = 1;
            item.vanity = true;
            item.value = 500000;
        }
    }
}
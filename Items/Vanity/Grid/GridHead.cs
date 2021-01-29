using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Grid

{
    [AutoloadEquip(EquipType.Head)]
    public class GridHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Grid's Facemask");
            Tooltip.SetDefault("A legendary piece of armor.\nMade by Grid");
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            // Custom RGB "Rarity"
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
            item.rare = ItemRarityID.White;
            item.vanity = true;
            item.value = 500000;
        }
        public override bool DrawHead()
        {
            return false;
        }
    }
}
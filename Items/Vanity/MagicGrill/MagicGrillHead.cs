using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.MagicGrill
{
    [AutoloadEquip(EquipType.Head)]
    public class MagicGrillHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Magic Grill Megashark Hood");
            Tooltip.SetDefault("Boss may be proud!\nMade by Pepsi");
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        { 
            // Custom RGB "Rarity"
            foreach (TooltipLine line2 in tooltips) {
                if (line2.mod == "Terraria" && line2.Name == "ItemName") {
                    line2.overrideColor = new Color(255, 158, 204);
                }
            }
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.White;
            item.vanity = true;
            item.value = 0;
        }

        public override void DrawHair(ref bool drawHair, ref bool drawAltHair)
        {
            drawAltHair = true;
        }
    }
}
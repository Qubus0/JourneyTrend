using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace JourneyTrend.Items.Vanity.Kuijia
{
    [AutoloadEquip(EquipType.Legs)]
    public class KuijiaLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Kuijia Legmail");
            Tooltip.SetDefault("Used by fighters for splash and impact protection.\nMade by PatisNow.");
        }
        public override void ModifyTooltips(List<TooltipLine> tooltips) {
            foreach (TooltipLine line2 in tooltips) {
                if (line2.mod == "Terraria" && line2.Name == "ItemName") {
                    line2.overrideColor = new Color(255, 152, 255);
                }
            }
        }
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = 1;
            item.vanity = true;
        }
    }
}
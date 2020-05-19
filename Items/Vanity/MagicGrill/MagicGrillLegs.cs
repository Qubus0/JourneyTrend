using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace JourneyTrend.Items.Vanity.MagicGrill
{
    [AutoloadEquip(EquipType.Legs)]
    public class MagicGrillLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Magic Shark Skirt");
            Tooltip.SetDefault("Use carefully on windy days.\nMade by Pepsi.");
        }
        public override void ModifyTooltips(List<TooltipLine> tooltips) {
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
            item.rare = 1;
            item.vanity = true;
        }
    }
}
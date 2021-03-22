using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Kuijia
{
    [AutoloadEquip(EquipType.Head)]
    public class KuijiaHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dragonhat");
            Tooltip.SetDefault("Used as a hat to protect from the sun and the rain.\nMade by PatisNow");
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            // Custom RGB "Rarity"
            foreach (var line2 in tooltips)
                if (line2.mod == "Terraria" && line2.Name == "ItemName")
                    line2.overrideColor = new Color(255, 152, 255);
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.White;
            item.vanity = true;
            item.value = 0;
        }
    }
}
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Grid

{
    [AutoloadEquip(EquipType.Legs)]
    public class GridLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Grid's Footgear");
            Tooltip.SetDefault("A legendary piece of armor.\nMade by Grid");
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            // Custom RGB "Rarity"
            foreach (var line2 in tooltips)
                if (line2.mod == "Terraria" && line2.Name == "ItemName")
                    line2.overrideColor = new Color(85, 0, 0);
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.White;
            Item.vanity = true;
            Item.value = 500000;
        }
    }
}
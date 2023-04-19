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

            ArmorIDs.Head.Sets.DrawHead[Item.headSlot] = false;
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            // Custom RGB "Rarity"
            foreach (var line2 in tooltips)
                if (line2.Mod == "Terraria" && line2.Name == "ItemName")
                    line2.OverrideColor = new Color(85, 0, 0);
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
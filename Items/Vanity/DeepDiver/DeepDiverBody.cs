using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.DeepDiver
{
    [AutoloadEquip(EquipType.Body)]
    public class DeepDiverBody : ModItem
    {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Deep Diver Torso");
            Tooltip.SetDefault("Stay warm in the depths of the ocean.\nMade by Nick T.");
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
    }
}

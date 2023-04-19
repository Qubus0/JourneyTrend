using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.DeepDiver
{
    [AutoloadEquip(EquipType.Body)]
    public class DeepDiverBody : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Deep Diver Torso");
            Tooltip.SetDefault("Stay warm in the depths of the ocean.\nMade by Nick T.");
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Blue;
            Item.vanity = true;
            Item.value = 100000; //only if sold.
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            foreach (var line2 in tooltips)
                if (line2.Mod == "Terraria" && line2.Name == "ItemName")
                    line2.OverrideColor = new Color(15, 4, 68);
        }
    }
}
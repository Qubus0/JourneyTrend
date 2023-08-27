using Terraria.GameContent.Creative;
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
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            // DisplayName.SetDefault("Magic Grill Megashark Hood");
            // Tooltip.SetDefault("Boss may be proud!\nMade by Pepsi");

            ArmorIDs.Head.Sets.DrawHatHair[Item.headSlot] = true;
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            // Custom RGB "Rarity"
            foreach (var line2 in tooltips)
                if (line2.Mod == "Terraria" && line2.Name == "ItemName")
                    line2.OverrideColor = new Color(255, 158, 204);
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.White;
            Item.vanity = true;
            Item.value = 0;
        }
    }
}
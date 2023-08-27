using Terraria.GameContent.Creative;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.ShadowSpell
{
    [AutoloadEquip(EquipType.Head)]
    public class ShadowSpellHead : ModItem
    {
        public override void SetStaticDefaults()
        {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            // DisplayName.SetDefault("Shadow Spell Hat");
            // Tooltip.SetDefault("Worn by the forgotten clan of the Shadowflame Shamans.\nMade by Romanov/Ammagon");
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.LightPurple;
            Item.vanity = true;
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            foreach (var line2 in tooltips)
                if (line2.Mod == "Terraria" && line2.Name == "ItemName")
                    line2.OverrideColor = new Color(114, 34, 170);
        }
    }
}
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Duality

{
    [AutoloadEquip(EquipType.Legs)]
    public class DualityLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Duality Pants");
            Tooltip.SetDefault("Past and future, walk the path from one to the other.\nMade by Chan");

            ArmorIDs.Legs.Sets.OverridesLegs[Item.legSlot] = true;
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            // Custom RGB "Rarity"
            foreach (var line2 in tooltips)
                if (line2.mod == "Terraria" && line2.Name == "ItemName")
                    line2.overrideColor = new Color(110, 101, 142);
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.vanity = true;
            Item.rare = ItemRarityID.White;
            Item.value = 0;
        }


        public override bool? CanBurnInLava()
        {
            return false;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.LightShard)
                .AddIngredient(ItemID.DarkShard)
                .AddTile(TileID.Loom)
                .Register();
        }
    }
}
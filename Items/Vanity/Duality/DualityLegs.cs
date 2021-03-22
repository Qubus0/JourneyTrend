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
            item.width = 18;
            item.height = 18;
            item.vanity = true;
            item.rare = ItemRarityID.White;
            item.value = 0;
        }


        public override bool CanBurnInLava()
        {
            return false;
        }

        public override void AddRecipes()
        {
            var recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LightShard);
            recipe.AddIngredient(ItemID.DarkShard);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override bool DrawLegs()
        {
            return false;
        }
    }
}
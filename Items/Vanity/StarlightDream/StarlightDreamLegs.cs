using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.StarlightDream
{
    [AutoloadEquip(EquipType.Legs)]
    public class StarlightDreamLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Set");
            Tooltip.SetDefault("Tooltip\nMade by Artist");
        }
        
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = 1;
            item.vanity = true;
            item.value = 50000;                             //only if sold.
        }

        //public override void AddRecipes()
        //{
        //    ModRecipe recipe = new ModRecipe(mod);
        //    recipe.AddTile(TileID.WorkBenches);
        //    recipe.AddIngredient(ItemID.Dirt, 5);
        //    recipe.AddRecipeGroup("IronBar", 3);
        //    recipe.needWater = true;
        //    recipe.SetResult(this);
        //    recipe.AddRecipe();
        //}

        //public override bool DrawLegs()
        //{
        //    return false;
        //}

        //public override void ModifyTooltips(List<TooltipLine> tooltips)
        //{
        //    foreach (TooltipLine line2 in tooltips)
        //    {
        //        if (line2.mod == "Terraria" && line2.Name == "ItemName")
        //        {
        //            line2.overrideColor = new Color(110, 101, 142);
        //        }
        //    }
        //}
    }
}
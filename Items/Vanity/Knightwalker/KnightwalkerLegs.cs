using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Knightwalker
{
    [AutoloadEquip(EquipType.Legs)]
    public class KnightwalkerLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Greaves of the Knightwalker");
            Tooltip.SetDefault("Made by Dusk Ealain");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Purple;
            item.vanity = true;
        }

        public override void AddRecipes()
        {
            if (WorldGen.crimson)
            {
                var recipe = new ModRecipe(mod);
                recipe.AddTile(TileID.Hellforge);
                recipe.AddIngredient(ItemID.UnicornHorn, 5);
                recipe.AddIngredient(ItemID.TissueSample, 5);
                recipe.AddIngredient(ItemID.Ichor, 5);
                recipe.AddRecipeGroup("IronBar", 15);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
            else
            {
                var recipe = new ModRecipe(mod);
                recipe.AddTile(TileID.Hellforge);
                recipe.AddIngredient(ItemID.UnicornHorn, 5);
                recipe.AddIngredient(ItemID.ShadowScale, 5);
                recipe.AddIngredient(ItemID.CursedFlame, 5);
                recipe.AddRecipeGroup("IronBar", 15);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }
}
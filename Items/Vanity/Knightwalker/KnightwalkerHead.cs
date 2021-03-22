using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Knightwalker
{
    [AutoloadEquip(EquipType.Head)]
    public class KnightwalkerHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Helmet of the Knightwalker");
            Tooltip.SetDefault("Made by Dusk Ealain");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Purple;
            item.vanity = true;
        }

        public override bool DrawHead()
        {
            return false;
        }

        public override void UpdateVanity(Player player, EquipType type)
        {
            player.GetModPlayer<JourneyPlayer>().KnightwalkerHeadEquipped = true;
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
                recipe.AddRecipeGroup("IronBar", 10);
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
                recipe.AddRecipeGroup("IronBar", 10);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }
}
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Knightwalker
{
    [AutoloadEquip(EquipType.Body)]
    public class KnightwalkerBody : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mantle of the Knightwalker");
            Tooltip.SetDefault("Burning Hot\nMade by Dusk Ealain");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Purple;
            item.vanity = true;
        }

        private readonly float adj = 0.00392f/2; //adjusts the rgb value from 0-255 to 0-1 because light is stupid like that
        public override void UpdateVanity(Player player, EquipType type)
        {
            Lighting.AddLight(player.Center, 204 * adj, 82 * adj, 255 * adj);
            player.GetModPlayer<JourneyPlayer>().KnightwalkerBodyEquipped = true;
            player.GetModPlayer<JourneyPlayer>().KnightwalkerAlt = false;
        }

        public override void AddRecipes()
        {
            if (WorldGen.crimson)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddTile(TileID.Hellforge);
                recipe.AddIngredient(ItemID.UnicornHorn, 5);
                recipe.AddIngredient(ItemID.TissueSample, 5);
                recipe.AddIngredient(ItemID.Ichor, 5);
                recipe.AddRecipeGroup("IronBar", 20);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
            else
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddTile(TileID.Hellforge);
                recipe.AddIngredient(ItemID.UnicornHorn, 5);
                recipe.AddIngredient(ItemID.ShadowScale, 5);
                recipe.AddIngredient(ItemID.CursedFlame, 5);
                recipe.AddRecipeGroup("IronBar", 20);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }

            ModRecipe alt = new ModRecipe(mod);
            alt.AddTile(mod.GetTile("SewingMachine"));
            alt.AddRecipeGroup("JourneyTrend:KnightwalkerCapes");
            alt.SetResult(this);
            alt.AddRecipe();
        }
    }
}
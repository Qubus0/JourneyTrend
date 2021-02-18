using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Nightlight
{
    [AutoloadEquip(EquipType.Body)]
    public class NightlightBody : ModItem
    {
        // Converts RGB 0-255 ==> RGB 0-1 and halves due to brightness (Cause light is stupid like that)
        private readonly float adj = 0.00392f / 2;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nightlight Body");
            Tooltip.SetDefault("A bright friendly glow in the night.\nMade by Metalsquirrel");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Green;
            item.vanity = true;
            item.value = 0;
        }

        public override void UpdateVanity(Player player, EquipType type)
        {
            Lighting.AddLight(player.Center, 198 * adj, 229 * adj, 10 * adj);
        }

        public override void AddRecipes()
        {
            var recipe = new ModRecipe(mod);
            recipe.AddTile(TileID.Loom);
            recipe.AddIngredient(ItemID.Silk, 15);
            recipe.AddIngredient(ItemID.Moonglow, 15);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
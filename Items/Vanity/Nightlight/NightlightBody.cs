using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Nightlight
{
    [AutoloadEquip(EquipType.Body)]
    public class NightlightBody : ModItem
    {
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
        }
                                                   //and halves it because bright
        private readonly float adj = 0.00392f/2; //adjusts the rgb value from 0-255 to 0-1 because light is stupid like that
        public override void UpdateVanity(Player player, EquipType type)
        {
            Lighting.AddLight(player.Center, 198 * adj, 229 * adj, 10 * adj);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddTile(TileID.Loom);
            recipe.AddIngredient(ItemID.Silk, 15);
            recipe.AddIngredient(ItemID.Moonglow, 15);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
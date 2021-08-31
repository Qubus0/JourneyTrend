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
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Green;
            Item.vanity = true;
            Item.value = 0;
        }

        public override void UpdateVanity(Player player)
        {
            Lighting.AddLight(player.Center, 198 * adj, 229 * adj, 10 * adj);
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddTile(TileID.Loom)
                .AddIngredient(ItemID.Silk, 15)
                .AddIngredient(ItemID.Moonglow, 15)
                .Register();
        }
    }
}
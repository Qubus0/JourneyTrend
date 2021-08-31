using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.ContainmentSuit
{
    [AutoloadEquip(EquipType.Body)]
    public class ContainmentSuitBody : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Containment Chestpiece");
            Tooltip.SetDefault("A traveler's chestpiece for harsh environments.\nMade by MikeLeaArt");
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Green;
            Item.vanity = true;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Silk, 3)
                .AddIngredient(ItemID.Wire, 4)
                .AddRecipeGroup("IronBar", 3)
                .AddTile(TileID.HeavyWorkBench)
                .Register();
        }
    }
}
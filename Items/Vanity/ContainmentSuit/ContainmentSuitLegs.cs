using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.ContainmentSuit
{
    [AutoloadEquip(EquipType.Legs)]
    public class ContainmentSuitLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Containment Boots");
            Tooltip.SetDefault("A traveler's boots for harsh environments.\nMade by MikeLeaArt");
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
                .AddIngredient(ItemID.Silk, 2)
                .AddIngredient(ItemID.Wire, 2)
                .AddRecipeGroup("IronBar", 3)
                .AddTile(TileID.HeavyWorkBench)
                .Register();
        }
    }
}
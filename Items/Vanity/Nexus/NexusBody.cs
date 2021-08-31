using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Nexus
{
    [AutoloadEquip(EquipType.Body)]
    public class NexusBody : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nexus Chestplate");
            Tooltip.SetDefault("You sense ceaseless energy coming from within\nMade by LazyGhost14");
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Green;
            Item.vanity = true;
            Item.value = 0;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddTile(TileID.MythrilAnvil)
                .AddRecipeGroup("IronBar", 20)
                .AddIngredient(ItemID.SoulofSight, 3)
                .AddIngredient(ItemID.Silk, 5)
                .Register();
        }
    }
}
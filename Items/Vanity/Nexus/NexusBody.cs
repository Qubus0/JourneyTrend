using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyTrend.Items.Vanity.Nexus
{
    [AutoloadEquip(EquipType.Body)]
    public class NexusBody : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nexus Chestplate");
            Tooltip.SetDefault("You sense ceaseless energy coming from within.\nMade by LazyGhost14");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = 2;
            item.vanity = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.AddRecipeGroup("IronBar", 20);
            recipe.AddIngredient(ItemID.SoulofSight, 3);
            recipe.AddIngredient(ItemID.Silk, 5);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
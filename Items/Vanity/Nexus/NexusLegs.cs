using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Nexus
{
    [AutoloadEquip(EquipType.Legs)]
    public class NexusLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            // DisplayName.SetDefault("Nexus Greaves");
            // Tooltip.SetDefault("Light and swift\nMade by LazyGhost14");
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
                .AddRecipeGroup("IronBar", 15)
                .AddIngredient(ItemID.SoulofSight, 3)
                .AddIngredient(ItemID.Silk, 3)
            .Register();
        }
    }
}
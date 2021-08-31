using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Invisible
{
    [AutoloadEquip(EquipType.Head)]
    public class InvisibleHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Can't");
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.White;
            Item.vanity = true;
        }

        public override bool DrawHead()
        {
            return false;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddTile<Tiles.SewingMachine>()
                .AddIngredient(ItemID.Glass)
                .AddCondition(Recipe.Condition.NearWater)
                .Register();
        }
    }
}
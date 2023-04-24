using Terraria.GameContent.Creative;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Bubblehead
{
    [AutoloadEquip(EquipType.Body)]
    public class BubbleheadBody : ModItem
    {
        public override void SetStaticDefaults()
        {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            DisplayName.SetDefault("Hydro Tank v3");
            Tooltip.SetDefault("One of the most modern supply tanks!\nMade by Metidigiti");
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.LightRed;
            Item.vanity = true;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.BottledWater)
                .AddIngredient(ItemID.Switch)
                .AddIngredient(ItemID.SoulofNight)
                .AddIngredient(ItemID.Wire, 20)
                .AddRecipeGroup("IronBar", 3)
                .AddCondition(Recipe.Condition.NearWater)
                .Register();
        }
    }
}
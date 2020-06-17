using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyTrend.Items.Vanity.WyvernRider
{
	[AutoloadEquip(EquipType.Wings)]
	public class WyvernRiderWings : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Wyvern Rider Tail");
			Tooltip.SetDefault("It doesn't allow you to ride wyverns, sorry.\nMade by manzXja");
		}

		public override void SetDefaults() {
			item.width = 22;
			item.height = 20;
			item.rare = 9;
			item.vanity = true;
			item.accessory = true;
		}

		public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddTile(TileID.SkyMill);
            recipe.AddIngredient(ItemID.Silk, 10);
            recipe.AddIngredient(ItemID.Cloud, 5);
            recipe.AddIngredient(ItemID.SoulofFlight, 3);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}
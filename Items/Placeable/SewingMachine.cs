using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyTrend.Items.Placeable
{
	public class SewingMachine : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Not so fond of that one vanity in particular? \nTry yoursef at the job of a tailor here.");
		}

		public override void SetDefaults() {
			item.width = 28;
			item.height = 14;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 150;
			item.createTile = TileType<Tiles.SewingMachine>();
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddTile(TileID.Anvils);
			recipe.AddRecipeGroup("IronBar", 8);
			recipe.AddRecipeGroup("PresurePlate", 1);
			recipe.AddIngredient(ItemID.Rope, 5);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
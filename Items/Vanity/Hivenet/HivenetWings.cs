using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace JourneyTrend.Items.Vanity.Hivenet
{
	[AutoloadEquip(EquipType.Wings)]
	public class HivenetWings : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("HiveNet Digital Wings");
			Tooltip.SetDefault("Cloud-based Engineering.");
		}

		public override void SetDefaults() {
			item.width = 22;
			item.height = 20;
			item.rare = 2;
			item.vanity = true;
			item.accessory = true;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.AddIngredient(ItemID.BeeWax, 5);
			recipe.AddIngredient(ItemID.SoulofFlight, 5);
			recipe.AddIngredient(ItemID.Wire, 15);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override void UpdateVanity(Player player, EquipType type) {
			if (Main.rand.NextFloat() < 0.1f) {
				Dust.NewDust(player.Center + new Vector2(-player.direction*30-20, -25), 40, 30, DustType<HivenetDust>());
			}
		}
	}
}
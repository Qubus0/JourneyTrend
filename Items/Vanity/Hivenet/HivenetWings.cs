using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyTrend.Items.Vanity.Hivenet
{
    [AutoloadEquip(EquipType.Wings)]
	public class HivenetWings : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("HiveNet Digital Wings");
			Tooltip.SetDefault("Cloud-based Engineering.\nMade by Sam Holt");
		}

		public override void SetDefaults() {
			item.width = 22;
			item.height = 20;
			item.rare = ItemRarityID.Green;
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
			if (Main.GameUpdateCount % 20 == 0) {
				Dust.NewDust(player.Center + new Vector2(-player.direction*30-20, -25), 40, 40, DustType<HivenetDust>());
			}
			//if (Main.rand.NextFloat() < 0.02f)		//for random particle spawns
			if (Main.GameUpdateCount % 30 == 0) {
				Dust.NewDust(player.Center + new Vector2(player.direction*30-20, -25), 10, 30, DustType<HivenetDust>());
			}
		}
	}
}
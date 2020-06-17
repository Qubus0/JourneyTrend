using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using static Terraria.ModLoader.ModContent;  //for dust

namespace JourneyTrend.Items.Vanity.WyvernRider
{
    [AutoloadEquip(EquipType.Body)]
    public class WyvernRiderBody : ModItem
    {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Wyvern Rider Shirt");
            Tooltip.SetDefault("It doesn't allow you to ride wyverns, sorry.\nMade by manzXja");
        }
        
        public override void SetDefaults() {
            item.width = 18;
            item.height = 18;
            item.rare = 9;
            item.vanity = true;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddTile(TileID.SkyMill);
            recipe.AddIngredient(ItemID.Silk, 8);
            recipe.AddIngredient(ItemID.Cloud, 10);
            recipe.AddIngredient(ItemID.SoulofFlight, 1);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
                
        public override void DrawHands(ref bool drawHands, ref bool drawArms) {
            drawHands = true;
        }

		public override void UpdateVanity(Player player, EquipType type) {
			if (player.velocity != Vector2.Zero && Main.rand.NextBool(3)) {
				Dust.NewDust(player.Center + new Vector2(-10 + player.direction * -15, -7), 20, 8, DustType<WyvernRiderDust>());
			}
		}
    }
}

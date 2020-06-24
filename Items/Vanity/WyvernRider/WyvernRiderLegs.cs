using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;  //for dust

namespace JourneyTrend.Items.Vanity.WyvernRider
{
    [AutoloadEquip(EquipType.Legs)]
    public class WyvernRiderLegs : ModItem
    {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Wyvern Rider Pants");
            Tooltip.SetDefault("It doesn't allow you to ride wyverns, sorry\nMade by manzXja");
        }
  
        public override void SetDefaults() {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Cyan;
            item.vanity = true;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddTile(TileID.SkyMill);
            recipe.AddIngredient(ItemID.Silk, 5);
            recipe.AddIngredient(ItemID.Cloud, 8);
            recipe.AddIngredient(ItemID.SoulofFlight, 1);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override void UpdateVanity(Player player, EquipType type)
        {
            if (player.velocity != Vector2.Zero && Main.rand.NextBool(5))
            {
                Dust.NewDust(player.Center + new Vector2(-5 + player.direction * -10, 16), 10, 2, DustType<WyvernRiderDust>());
            }
        }
    }
}

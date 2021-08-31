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
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("HiveNet Digital Wings");
            Tooltip.SetDefault("Cloud-based Engineering.\nMade by Sam Holt");
        }

        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 20;
            Item.rare = ItemRarityID.Green;
            Item.vanity = true;
            Item.accessory = true;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddTile(TileID.MythrilAnvil)
                .AddIngredient(ItemID.BeeWax, 5)
                .AddIngredient(ItemID.SoulofFlight, 5)
                .AddIngredient(ItemID.Wire, 15)
                .Register();
        }

        public override void UpdateVanity(Player player)
        {
            //if (Main.rand.NextFloat() < 0.02f)		//for random particle spawns

            if (Main.GameUpdateCount % 20 == 0)
            {
                //big wing
                var wid = 40;
                var hei = 40;
                Dust.NewDust(player.Center + new Vector2(-(wid / 2) - player.direction * 30, -25), wid, hei,
                    DustType<HivenetDust>());
            }

            if (Main.GameUpdateCount % 30 == 0)
            {
                //smol wing
                var wid = 10;
                var hei = 30;
                Dust.NewDust(player.Center + new Vector2(-(wid / 2) + player.direction * 18, -25), wid, hei,
                    DustType<HivenetDust>());
            }
        }
    }
}
using Terraria.GameContent.Creative;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.Graphics.Shaders;
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
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            DisplayName.SetDefault("HiveNet Digital Wings");
            Tooltip.SetDefault("Cloud-based Engineering.\nMade by Sam Holt");
            
            // These wings use the same values as the fledgling wings
            ArmorIDs.Wing.Sets.Stats[Item.wingSlot] = new WingStats(25, 2.5f, 1.5f);
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

        public override void EquipFrameEffects(Player player, EquipType type)
        {
            if (Main.GameUpdateCount % 20 == 0)
            {
                // big front wing
                var wid = 40;
                var hei = 40;
                Dust.NewDustDirect(player.Center + new Vector2(-(wid / 2) - player.direction * 30, -25), wid, hei,
                    DustType<HivenetDust>())
                    .shader = GameShaders.Armor.GetSecondaryShader(player.cWings, player);
            }

            if (Main.GameUpdateCount % 30 == 0)
            {
                // small back wing
                var wid = 10;
                var hei = 30;
                Dust.NewDustDirect(player.Center + new Vector2(-(wid / 2) + player.direction * 18, -25), wid, hei,
                    DustType<HivenetDust>())
                    .shader = GameShaders.Armor.GetSecondaryShader(player.cWings, player);
            }
        }
    }
}
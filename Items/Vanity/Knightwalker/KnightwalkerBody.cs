using Terraria.GameContent.Creative;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyTrend.Items.Vanity.Knightwalker
{
    [AutoloadEquip(EquipType.Body)]
    public class KnightwalkerBody : ModItem
    {
        private readonly float
            adj = 0.00392f / 2; //adjusts the rgb value from 0-255 to 0-1 because light is stupid like that

        public override void SetStaticDefaults()
        {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            // DisplayName.SetDefault("Mantle of the Knightwalker");
            // Tooltip.SetDefault("Burning Hot\nMade by Dusk Ealain");
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Purple;
            Item.vanity = true;
        }

        public override void EquipFrameEffects(Player player, EquipType type)
        {
            player.GetModPlayer<JourneyPlayer>().KnightwalkerBodyEquipped = true;

            Lighting.AddLight(player.Center, 204 * adj, 82 * adj, 255 * adj);

            var walkUpShift = player.GetModPlayer<JourneyPlayer>().GetWalkUpShift();

            if (player.GetModPlayer<JourneyPlayer>().IsIdle()) return;
            switch (Main.GameUpdateCount % 4)
            {
                case 0:
                    Dust.NewDustPerfect(player.Center + new Vector2(player.direction * 9, -2 + walkUpShift),
                        DustType<KnightwalkerDust>());
                    Dust.NewDustPerfect(player.Center + new Vector2(-player.direction * 9, -2 + walkUpShift),
                        DustType<KnightwalkerDust>());
                    break;
                case 2:
                    Dust.NewDustPerfect(player.Center + new Vector2(-player.direction * 11, -2 + walkUpShift),
                        DustType<KnightwalkerDust>());
                    break;
            }
        }

        public override void AddRecipes()
        {
            if (WorldGen.crimson)
            {
                CreateRecipe()
                    .AddTile(TileID.Hellforge)
                    .AddIngredient(ItemID.UnicornHorn, 5)
                    .AddIngredient(ItemID.TissueSample, 5)
                    .AddIngredient(ItemID.Ichor, 5)
                    .AddRecipeGroup("IronBar", 20)
                    .Register();
            }
            else
            {
                CreateRecipe()
                    .AddTile(TileID.Hellforge)
                    .AddIngredient(ItemID.UnicornHorn, 5)
                    .AddIngredient(ItemID.ShadowScale, 5)
                    .AddIngredient(ItemID.CursedFlame, 5)
                    .AddRecipeGroup("IronBar", 20)
                    .Register();
            }
        }
    }
}
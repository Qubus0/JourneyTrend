using Terraria.GameContent.Creative;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyTrend.Items.Vanity.Knightwalker
{
    [AutoloadEquip(EquipType.Body)]
    public class KnightwalkerBody : ModItem
    {
        private readonly Color LightColor = ColorUtils.DimColor(new Color(204, 82, 255), 0.5f);

        public override void SetStaticDefaults()
        {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            DisplayName.SetDefault("Mantle of the Knightwalker");
            Tooltip.SetDefault("Burning Hot\nMade by Dusk Ealain");
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

            Lighting.AddLight(player.Center, ColorUtils.ShaderResponsiveColor(LightColor, player.cBody, player));

            var walkUpShift = player.GetModPlayer<JourneyPlayer>().GetWalkUpShift();

            if (player.GetModPlayer<JourneyPlayer>().IsIdle()) return;
            
            var bodyShader = GameShaders.Armor.GetSecondaryShader(player.cBody, player);
            switch (Main.GameUpdateCount % 4)
            {
                case 0:
                    Dust.NewDustPerfect(player.Center + new Vector2(player.direction * 9, -2 + walkUpShift),
                        DustType<KnightwalkerDust>())
                        .shader = bodyShader;
                    Dust.NewDustPerfect(player.Center + new Vector2(-player.direction * 9, -2 + walkUpShift),
                        DustType<KnightwalkerDust>())
                        .shader = bodyShader;
                    break;
                case 2:
                    Dust.NewDustPerfect(player.Center + new Vector2(-player.direction * 11, -2 + walkUpShift),
                        DustType<KnightwalkerDust>())
                        .shader = bodyShader;
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
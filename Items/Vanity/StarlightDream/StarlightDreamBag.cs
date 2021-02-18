using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyTrend.Items.Vanity.StarlightDream
{
    public class StarlightDreamBag : ModItem
    {
        private readonly float
            adj = 0.00392f / 2; //adjusts the rgb value from 0-255 to 0-1 because light is stupid like that

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Starlight Dream Bag");
            Tooltip.SetDefault("Sprinting assisted by Cakeboiii\n{$CommonItemTooltip.RightClickToOpen}");
        }

        public override void SetDefaults()
        {
            item.maxStack = 999;
            item.consumable = true;
            item.width = 24;
            item.height = 24;
            item.rare = ItemRarityID.Blue;
        }

        public override bool CanRightClick()
        {
            return true;
        }

        public override void Update(ref float gravity, ref float maxFallSpeed)
        {
            Lighting.AddLight(item.Center, 241 * adj, 215 * adj, 108 * adj);
            if (Main.dayTime && Main.time == 0)
            {
                item.TurnToAir();
                for (var i = 0; i < 20; i++) Dust.NewDust(item.Center, 20, 8, 15);
            }
        }


        public override void PostDrawInWorld(SpriteBatch spriteBatch, Color lightColor, Color alphaColor,
            float rotation, float scale, int whoAmI)
        {
            var texture = mod.GetTexture("Items/Vanity/StarlightDream/StarlightDreamBag_Glow");
            spriteBatch.Draw
            (
                texture,
                new Vector2
                (
                    item.position.X - Main.screenPosition.X + item.width * 0.5f,
                    item.position.Y - Main.screenPosition.Y + item.height - texture.Height * 0.5f + 2f
                ),
                new Rectangle(0, 0, texture.Width, texture.Height),
                Color.White,
                rotation,
                texture.Size() * 0.5f,
                scale,
                SpriteEffects.None,
                0f
            );
        }

        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(ItemType<StarlightDreamLegs>());
            player.QuickSpawnItem(ItemType<StarlightDreamBody>());
            player.QuickSpawnItem(ItemType<StarlightDreamHead>());
        }
    }
}
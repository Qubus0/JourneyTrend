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
        private const float Adj = 0.00392f / 2; //adjusts the rgb value from 0-255 to 0-1 because light is stupid

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Starlight Dream Bag");
            Tooltip.SetDefault("Spriting assisted by Cakeboiii\n{$CommonItemTooltip.RightClickToOpen}");
        }

        public override void SetDefaults()
        {
            Item.maxStack = 999;
            Item.consumable = true;
            Item.width = 24;
            Item.height = 24;
            Item.rare = ItemRarityID.Blue;
        }

        public override bool CanRightClick()
        {
            return true;
        }

        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(ItemType<StarlightDreamLegs>());
            player.QuickSpawnItem(ItemType<StarlightDreamBody>());
            player.QuickSpawnItem(ItemType<StarlightDreamHead>());
        }
        
        public override void Update(ref float gravity, ref float maxFallSpeed)
        {
            Lighting.AddLight(Item.Center, 241 * Adj, 215 * Adj, 108 * Adj);
            if (Main.dayTime && Main.time == 0)
            {
                Item.TurnToAir();
                for (var i = 0; i < 20; i++) Dust.NewDust(Item.Center, 20, 8, 15);
            }
        }

        public override void PostDrawInWorld(SpriteBatch spriteBatch, Color lightColor, Color alphaColor,
            float rotation, float scale, int whoAmI)
        {
            var texture = ModContent.Request<Texture2D>("JourneyTrend/Items/Vanity/StarlightDream/StarlightDreamBag_Glow").Value;
            spriteBatch.Draw
            (
                texture,
                new Vector2
                (
                    Item.position.X - Main.screenPosition.X + Item.width * 0.5f,
                    Item.position.Y - Main.screenPosition.Y + Item.height - texture.Height * 0.5f + 2f
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
    }
}
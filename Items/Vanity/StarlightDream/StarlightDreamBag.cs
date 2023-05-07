using Terraria.GameContent.Creative;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyTrend.Items.Vanity.StarlightDream
{
    public class StarlightDreamBag : ModItem
    {
        private readonly Vector3 LightColor = ColorUtils.DimColor(new Color(241, 215, 108), 0.5f).ToVector3();

        public override void SetStaticDefaults()
        {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
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

        public override void ModifyItemLoot(ItemLoot itemLoot)
        {
            itemLoot.Add(ItemDropRule.Common(ItemType<StarlightDreamLegs>()));
            itemLoot.Add(ItemDropRule.Common(ItemType<StarlightDreamBody>()));
            itemLoot.Add(ItemDropRule.Common(ItemType<StarlightDreamHead>()));
        }
        
        public override void Update(ref float gravity, ref float maxFallSpeed)
        {
            Lighting.AddLight(Item.Center, LightColor);
            if (Main.dayTime && Main.time == 0)
            {
                Item.TurnToAir();
                for (var i = 0; i < 20; i++) Dust.NewDust(Item.Center, 20, 8, DustID.MagicMirror);
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
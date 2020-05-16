using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.Utilities;
using Terraria.DataStructures;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using JourneyTrend.Items.Vanity.ContainmentSuit;

namespace JourneyTrend
{
    public class JourneyPlayer : ModPlayer
    {
        public bool containmentHeadGlowmask;
        public bool containmentBodyGlowmask;
        public override void UpdateVanityAccessories()
        {
            containmentHeadGlowmask = false;
            containmentBodyGlowmask = false;
            for (int n = 0; n < 18 + player.extraAccessorySlots; n++)
            {
                Item item = player.armor[n];
                if (item.type == mod.ItemType("ContainmentHead"))
                {
                    containmentHeadGlowmask = true;
                }
                else if (item.type == mod.ItemType("ContainmentBody"))
                {
                    containmentBodyGlowmask = true;
                }
            }
        }
        public static readonly PlayerLayer MiscEffects = new PlayerLayer("JourneyTrend", "MiscEffects", PlayerLayer.MiscEffectsFront, delegate (PlayerDrawInfo drawInfo)
        {
            JourneyPlayer mp = drawInfo.drawPlayer.GetModPlayer<JourneyPlayer>();
            Player drawPlayer = drawInfo.drawPlayer;
            if (mp.containmentHeadGlowmask)
            {
                Texture2D texture = ModContent.GetTexture("JourneyTrend/Items/Vanity/ContainmentSuit/ContainmentHead_Glowmask");
                int drawX = (int)(drawInfo.position.X + drawPlayer.width / 2f - Main.screenPosition.X);
                int drawY = (int)(drawInfo.position.Y + drawPlayer.height / 2f - Main.screenPosition.Y);
                DrawData data = new DrawData(texture, new Vector2(drawX, drawY), null, Lighting.GetColor((int)((drawInfo.position.X + drawPlayer.width / 2f) / 16f), (int)((drawInfo.position.Y - 4f - texture.Height / 2f) / 16f)), 0f, new Vector2(texture.Width / 2f, texture.Height), 1f, SpriteEffects.None, 0);
            }
            if (mp.containmentBodyGlowmask)
            {
                Texture2D texture = ModContent.GetTexture("JourneyTrend/Items/Vanity/ContainmentSuit/ContainmentBody_Glowmask");
                int drawX = (int)(drawInfo.position.X + drawPlayer.width / 2f - Main.screenPosition.X);
                int drawY = (int)(drawInfo.position.Y + drawPlayer.height / 2f - Main.screenPosition.Y);
                DrawData data = new DrawData(texture, new Vector2(drawX, drawY), null, Lighting.GetColor((int)((drawInfo.position.X + drawPlayer.width / 2f) / 16f), (int)((drawInfo.position.Y - 4f - texture.Height / 2f) / 16f)), 0f, new Vector2(texture.Width / 2f, texture.Height), 1f, SpriteEffects.None, 0);
            }
        });
    }
}
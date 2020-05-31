using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.Utilities;
using Terraria.DataStructures;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria.Graphics.Shaders;
using System.Collections.Generic;

namespace JourneyTrend
{
    public class JourneyPlayer : ModPlayer
	{
		public static readonly PlayerLayer ContainmentHeadGlowmask = new PlayerLayer("JourneyTrend", "ContainmentHeadGlowmask", PlayerLayer.Head, delegate (PlayerDrawInfo drawInfo) {
			if (drawInfo.shadow != 0f || drawInfo.drawPlayer.dead)
			{
				return;
			}
			Player drawPlayer = drawInfo.drawPlayer;
			Mod mod = ModLoader.GetMod("JourneyTrend");
			if (drawPlayer.head != mod.GetEquipSlot("ContainmentHead", EquipType.Head))
			{
				return;
			}
			Texture2D texture = mod.GetTexture("Items/Vanity/ContainmentSuit/ContainmentHead_Glowmask");
			float drawX = (int)drawInfo.position.X + drawPlayer.width / 2;
			float drawY = (int)drawInfo.position.Y + drawPlayer.height - drawPlayer.bodyFrame.Height / 2 + 4f;
			Vector2 origin = drawInfo.headOrigin;
			Vector2 position = new Vector2(drawX, drawY) + drawPlayer.headPosition - Main.screenPosition;
			float alpha = (255 - drawPlayer.immuneAlpha) / 255f;
			Color color = Color.White;
			Rectangle frame = drawPlayer.headFrame;
			float rotation = drawPlayer.headRotation;
			SpriteEffects spriteEffects = drawInfo.spriteEffects;
			DrawData drawData = new DrawData(texture, position, frame, color * alpha, rotation, origin, 1f, spriteEffects, 0);
			drawData.shader = drawInfo.headArmorShader;
			Main.playerDrawData.Add(drawData);
		});
		public static readonly PlayerLayer ContainmentBodyGlowmask = new PlayerLayer("JourneyTrend", "ContainmentBodyGlowmask", PlayerLayer.Body, delegate (PlayerDrawInfo drawInfo) {
			if (drawInfo.shadow != 0f || drawInfo.drawPlayer.dead)
			{
				return;
			}
			Player drawPlayer = drawInfo.drawPlayer;
			Mod mod = ModLoader.GetMod("JourneyTrend");
			if (drawPlayer.body != mod.GetEquipSlot("ContainmentBody", EquipType.Body))
			{
				return;
			}
			Texture2D texture = mod.GetTexture("Items/Vanity/ContainmentSuit/ContainmentBody_Glowmask");
			float drawX = (int)drawInfo.position.X + drawPlayer.width / 2;
			float drawY = (int)drawInfo.position.Y + drawPlayer.height - drawPlayer.bodyFrame.Height / 2 + 4f;
			Vector2 origin = drawInfo.bodyOrigin;
			Vector2 position = new Vector2(drawX, drawY) + drawPlayer.bodyPosition - Main.screenPosition;
			float alpha = (255 - drawPlayer.immuneAlpha) / 255f;
			Color color = Color.White;
			Rectangle frame = drawPlayer.bodyFrame;
			float rotation = drawPlayer.bodyRotation;
			SpriteEffects spriteEffects = drawInfo.spriteEffects;
			DrawData drawData = new DrawData(texture, position, frame, color * alpha, rotation, origin, 1f, spriteEffects, 0);
			drawData.shader = drawInfo.bodyArmorShader;
			Main.playerDrawData.Add(drawData);
		});
		public override void ModifyDrawLayers(List<PlayerLayer> layers)
		{
			int headLayer = layers.FindIndex(l => l == PlayerLayer.Head);
			int bodyLayer = layers.FindIndex(l => l == PlayerLayer.Body);
			if (headLayer > -1)
			{
				layers.Insert(headLayer + 1, ContainmentHeadGlowmask);
			}
			if (bodyLayer > -1)
			{
				layers.Insert(bodyLayer + 1, ContainmentBodyGlowmask);
			}
		}
	}
}
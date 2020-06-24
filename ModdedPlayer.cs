using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.ObjectData;
using Terraria.Localization;
using static Terraria.ModLoader.ModContent;
using System.Runtime.Remoting.Messaging;
using Terraria.Graphics.Shaders;

namespace JourneyTrend
{
    public class JourneyPlayer : ModPlayer
	{
		// For Idle Animating (Fox Tails)
		public bool foxTails;
		private int tailFrameUp;
		private int tailFrame;
		private int tailShader = 0;
		private int tailFrame2 = 0;
		public bool foxFly;
		public static readonly PlayerLayer NineTailedFoxTail = new PlayerLayer("JourneyTrend", "NineTailedFoxTail", PlayerLayer.WaistAcc, delegate (PlayerDrawInfo drawInfo)
		{
			if (!drawInfo.drawPlayer.dead)
			{
				Player drawPlayer = drawInfo.drawPlayer;
				Mod mod = ModLoader.GetMod("JourneyTrend");
				JourneyPlayer modPlayer = drawPlayer.GetModPlayer<JourneyPlayer>();
				if (modPlayer.foxTails)
				{
					Rectangle? rectangle = new Rectangle(0, modPlayer.tailFrame * 56, 46, 56);
					Color newColor = Lighting.GetColor((int)((drawInfo.position.X + drawPlayer.width / 2f) / 16f),
					(int)((drawInfo.position.Y + drawPlayer.height / 2f) / 16f));
					newColor = new Color(newColor.R, newColor.B, newColor.G, (int)((1 - drawPlayer.shadow) * 255));
					Texture2D texture = mod.GetTexture("Items/Vanity/NineTailedFox/NineTailedFoxAcc_Tails");
					int num = texture.Height / 11;
					int num2 = (int)(drawInfo.position.X + drawPlayer.width / 2f - Main.screenPosition.X - (3 * drawPlayer.direction));
					int num3 = (int)(drawInfo.position.Y + drawPlayer.height / 2f - Main.screenPosition.Y - 3f);
					DrawData item = new DrawData(texture, new Vector2(num2, num3), rectangle,
					newColor, 0f, new Vector2(texture.Width / 2f, num / 2f), 1f, drawInfo.spriteEffects, 0)
					{
						shader = drawPlayer.cWings
					};
					Main.playerDrawData.Add(item);
				}
			}
		});
		public override void ResetEffects()
		{
			foxTails = false;
			foxFly = false;
		}
		public override void PreUpdate()
		{
			tailFrameUp++;
			if (tailFrameUp == 8)
			{
				tailFrame2++;
				if (tailFrame2 >= 10)
				{
					tailFrame2 = 0;
				}
				tailFrameUp = 0;
			}
			if (!foxFly) { tailFrame = tailFrame2; }
			else { tailFrame = 10; }
		}
		public static readonly PlayerLayer ContainmentHeadGlowmask = new PlayerLayer("JourneyTrend", "ContainmentHeadGlowmask", PlayerLayer.Head, delegate (PlayerDrawInfo drawInfo)
		{
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
			float drawY = (int)drawInfo.position.Y + drawPlayer.height - drawPlayer.headFrame.Height / 2 + 4f - 34f;
			Vector2 origin = drawInfo.headOrigin;
			Vector2 position = new Vector2(drawX, drawY) + drawPlayer.headPosition - Main.screenPosition;
			float alpha = (255 - drawPlayer.immuneAlpha) / 255f;
			Color color = Color.White;
			Rectangle frame = new Rectangle(0, drawPlayer.bodyFrame.Y, texture.Width, texture.Height / 20);
			float rotation = drawPlayer.headRotation;
			SpriteEffects spriteEffects = drawInfo.spriteEffects;
			DrawData drawData = new DrawData(texture, position, frame, color * alpha, rotation, origin, 1f, spriteEffects, 0);
			drawData.shader = drawInfo.headArmorShader;
			Main.playerDrawData.Add(drawData);
		});

		public static readonly PlayerLayer ContainmentBodyGlowmask = new PlayerLayer("JourneyTrend", "ContainmentBodyGlowmask", PlayerLayer.Body, delegate (PlayerDrawInfo drawInfo)
		{
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

		public static readonly PlayerLayer CyberAngelHeadGlowmask = new PlayerLayer("JourneyTrend", "CyberAngelHeadGlowmask", PlayerLayer.Head, delegate (PlayerDrawInfo drawInfo)
		{
			if (drawInfo.shadow != 0f || drawInfo.drawPlayer.dead)
			{
				return;
			}
			Player drawPlayer = drawInfo.drawPlayer;
			Mod mod = ModLoader.GetMod("JourneyTrend");
			if (drawPlayer.head != mod.GetEquipSlot("CyberAngelHead", EquipType.Head) && drawPlayer.head != mod.GetEquipSlot("CyberAngelHead1", EquipType.Head))
			{
				return;
			}
			Texture2D texture = mod.GetTexture("Items/Vanity/CyberAngel/CyberAngelHead_Glow");
			float drawX = (int)drawInfo.position.X + drawPlayer.width / 2;
			float drawY = (int)drawInfo.position.Y + drawPlayer.height - drawPlayer.headFrame.Height / 2 + 4f - 34f;
			Vector2 origin = drawInfo.headOrigin;
			Vector2 position = new Vector2(drawX, drawY) + drawPlayer.headPosition - Main.screenPosition;
			float alpha = (255 - drawPlayer.immuneAlpha) / 255f;
			Color color = Color.White;
			Rectangle frame = new Rectangle(0, drawPlayer.bodyFrame.Y, texture.Width, texture.Height / 20);
			float rotation = drawPlayer.headRotation;
			SpriteEffects spriteEffects = drawInfo.spriteEffects;
			DrawData drawData = new DrawData(texture, position, frame, color * alpha, rotation, origin, 1f, spriteEffects, 0);
			drawData.shader = drawInfo.headArmorShader;
			Main.playerDrawData.Add(drawData);
		});

		public static readonly PlayerLayer CyberAngelBodyGlowmask = new PlayerLayer("JourneyTrend", "CyberAngelBodyGlowmask", PlayerLayer.Body, delegate (PlayerDrawInfo drawInfo)
		{
			if (drawInfo.shadow != 0f || drawInfo.drawPlayer.dead)
			{
				return;
			}
			Player drawPlayer = drawInfo.drawPlayer;
			Mod mod = ModLoader.GetMod("JourneyTrend");
			if (drawPlayer.body != mod.GetEquipSlot("CyberAngelBody", EquipType.Body))
			{
				return;
			}
			Texture2D texture = mod.GetTexture("Items/Vanity/CyberAngel/CyberAngelBody_Glow");
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

		public static readonly PlayerLayer CyberAngelLegsGlowmask = new PlayerLayer("JourneyTrend", "CyberAngelLegsGlowmask", PlayerLayer.Legs, delegate (PlayerDrawInfo drawInfo)
		{
			if (drawInfo.shadow != 0f || drawInfo.drawPlayer.dead)
			{
				return;
			}
			Player drawPlayer = drawInfo.drawPlayer;
			Mod mod = ModLoader.GetMod("JourneyTrend");
			if (drawPlayer.legs != mod.GetEquipSlot("CyberAngelLegs", EquipType.Legs))
			{
				return;
			}
			Texture2D texture = mod.GetTexture("Items/Vanity/CyberAngel/CyberAngelLegs_Glow");
			float drawX = (int)drawInfo.position.X + drawPlayer.width / 2;
			float drawY = (int)drawInfo.position.Y + drawPlayer.height - drawPlayer.legFrame.Height / 2 + 4f + 14f;
			Vector2 origin = drawInfo.legOrigin;
			Vector2 position = new Vector2(drawX, drawY) + drawPlayer.legPosition - Main.screenPosition;
			float alpha = (255 - drawPlayer.immuneAlpha) / 255f;
			Color color = new Color(255 * 100 / 100, 255 * 100 / 100, 255 * 100 / 100);
			Rectangle frame = drawPlayer.legFrame;
			float rotation = drawPlayer.legRotation;
			SpriteEffects spriteEffects = drawInfo.spriteEffects;
			DrawData drawData = new DrawData(texture, position, frame, color * alpha, rotation, origin, 1f, spriteEffects, 0);
			drawData.shader = drawInfo.legArmorShader;
			Main.playerDrawData.Add(drawData);
		});

		public static readonly PlayerLayer MushroomHeadGlowmask = new PlayerLayer("JourneyTrend", "MushroomHeadGlowmask", PlayerLayer.Head, delegate (PlayerDrawInfo drawInfo)
		{
			if (drawInfo.shadow != 0f || drawInfo.drawPlayer.dead)
			{
				return;
			}
			Player drawPlayer = drawInfo.drawPlayer;
			Mod mod = ModLoader.GetMod("JourneyTrend");
			if (drawPlayer.head != mod.GetEquipSlot("MushroomAlchemistHead", EquipType.Head))
			{
				return;
			}
			Texture2D texture = mod.GetTexture("Items/Vanity/MushroomAlchemist/MushroomAlchemistHead_Glow");
			float drawX = (int)drawInfo.position.X + drawPlayer.width / 2;
			float drawY = (int)drawInfo.position.Y + drawPlayer.height - drawPlayer.headFrame.Height / 2 + 4f - 34f;
			Vector2 origin = drawInfo.headOrigin;
			Vector2 position = new Vector2(drawX, drawY) + drawPlayer.headPosition - Main.screenPosition;
			float alpha = (255 - drawPlayer.immuneAlpha) / 255f;
			Color color = Color.White;
			Rectangle frame = new Rectangle(0, drawPlayer.bodyFrame.Y, texture.Width, texture.Height / 20);
			float rotation = drawPlayer.headRotation;
			SpriteEffects spriteEffects = drawInfo.spriteEffects;
			DrawData drawData = new DrawData(texture, position, frame, color * alpha, rotation, origin, 1f, spriteEffects, 0);
			drawData.shader = drawInfo.headArmorShader;
			Main.playerDrawData.Add(drawData);
		});

		public static readonly PlayerLayer MushroomBodyGlowmask = new PlayerLayer("JourneyTrend", "MushroomBodyGlowmask", PlayerLayer.Body, delegate (PlayerDrawInfo drawInfo)
		{
			if (drawInfo.shadow != 0f || drawInfo.drawPlayer.dead)
			{
				return;
			}
			Player drawPlayer = drawInfo.drawPlayer;
			Mod mod = ModLoader.GetMod("JourneyTrend");
			if (drawPlayer.body != mod.GetEquipSlot("MushroomAlchemistBody", EquipType.Body))
			{
				return;
			}
			Texture2D texture = mod.GetTexture("Items/Vanity/MushroomAlchemist/MushroomAlchemistBody_Glow");
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

		public static readonly PlayerLayer MushroomLegsGlowmask = new PlayerLayer("JourneyTrend", "MushroomLegsGlowmask", PlayerLayer.Legs, delegate (PlayerDrawInfo drawInfo)
		{
			if (drawInfo.shadow != 0f || drawInfo.drawPlayer.dead)
			{
				return;
			}
			Player drawPlayer = drawInfo.drawPlayer;
			Mod mod = ModLoader.GetMod("JourneyTrend");
			if (drawPlayer.legs != mod.GetEquipSlot("MushroomAlchemistLegs", EquipType.Legs))
			{
				return;
			}
			Texture2D texture = mod.GetTexture("Items/Vanity/MushroomAlchemist/MushroomAlchemistLegs_Glow");
			float drawX = (int)drawInfo.position.X + drawPlayer.width / 2;
			float drawY = (int)drawInfo.position.Y + drawPlayer.height - drawPlayer.legFrame.Height / 2 + 4f + 14f;
			Vector2 origin = drawInfo.legOrigin;
			Vector2 position = new Vector2(drawX, drawY) + drawPlayer.legPosition - Main.screenPosition;
			float alpha = (255 - drawPlayer.immuneAlpha) / 255f;
			Color color = new Color(255 * 100 / 100, 255 * 100 / 100, 255 * 100 / 100);
			Rectangle frame = drawPlayer.legFrame;
			float rotation = drawPlayer.legRotation;
			SpriteEffects spriteEffects = drawInfo.spriteEffects;
			DrawData drawData = new DrawData(texture, position, frame, color * alpha, rotation, origin, 1f, spriteEffects, 0);
			drawData.shader = drawInfo.legArmorShader;
			Main.playerDrawData.Add(drawData);
		});

		public static readonly PlayerLayer MushroomArmsGlowmask = new PlayerLayer("JourneyTrend", "MushroomArmsGlowmask", PlayerLayer.Arms, delegate (PlayerDrawInfo drawInfo)
		{
			if (drawInfo.shadow != 0f || drawInfo.drawPlayer.dead)
			{
				return;
			}
			Player drawPlayer = drawInfo.drawPlayer;
			Mod mod = ModLoader.GetMod("JourneyTrend");
			if (drawPlayer.legs != mod.GetEquipSlot("MushroomAlchemistBody", EquipType.Body))
			{
				return;
			}
			Texture2D texture = mod.GetTexture("Items/Vanity/MushroomAlchemist/MushroomAlchemistBody_ArmsGlow");
			float drawX = (int)drawInfo.position.X + drawPlayer.width / 2;
			float drawY = (int)drawInfo.position.Y + drawPlayer.height - drawPlayer.bodyFrame.Height / 2 + 4f;
			Vector2 origin = drawInfo.bodyOrigin;
			Vector2 position = new Vector2(drawX, drawY) + drawPlayer.bodyPosition - Main.screenPosition;
			float alpha = (255 - drawPlayer.immuneAlpha) / 255f;
			Color color = new Color(255 * 100 / 100, 255 * 100 / 100, 255 * 100 / 100);
			Rectangle frame = drawPlayer.bodyFrame;
			float rotation = drawPlayer.bodyRotation;
			SpriteEffects spriteEffects = drawInfo.spriteEffects;
			DrawData drawData = new DrawData(texture, position, frame, color * alpha, rotation, origin, 1f, spriteEffects, 0);
			drawData.shader = drawInfo.bodyArmorShader;
			Main.playerDrawData.Add(drawData);
		});

		public static readonly PlayerLayer NexusHeadGlowmask = new PlayerLayer("JourneyTrend", "NexusHeadGlowmask", PlayerLayer.Head, delegate (PlayerDrawInfo drawInfo)
		{
			if (drawInfo.shadow != 0f || drawInfo.drawPlayer.dead)
			{
				return;
			}
			Player drawPlayer = drawInfo.drawPlayer;
			Mod mod = ModLoader.GetMod("JourneyTrend");
			if (drawPlayer.head != mod.GetEquipSlot("NexusHead", EquipType.Head))
			{
				return;
			}
			Texture2D texture = mod.GetTexture("Items/Vanity/Nexus/NexusHead_Glow");
			float drawX = (int)drawInfo.position.X + drawPlayer.width / 2;
			float drawY = (int)drawInfo.position.Y + drawPlayer.height - drawPlayer.headFrame.Height / 2 + 4f - 34f;
			Vector2 origin = drawInfo.headOrigin;
			Vector2 position = new Vector2(drawX, drawY) + drawPlayer.headPosition - Main.screenPosition;
			float alpha = (255 - drawPlayer.immuneAlpha) / 255f;
			Color color = Color.White;
			Rectangle frame = new Rectangle(0, drawPlayer.bodyFrame.Y, texture.Width, texture.Height / 20);
			float rotation = drawPlayer.headRotation;
			SpriteEffects spriteEffects = drawInfo.spriteEffects;
			DrawData drawData = new DrawData(texture, position, frame, color * alpha, rotation, origin, 1f, spriteEffects, 0);
			drawData.shader = drawInfo.headArmorShader;
			Main.playerDrawData.Add(drawData);
		});

		public static readonly PlayerLayer NexusBodyGlowmask = new PlayerLayer("JourneyTrend", "NexusBodyGlowmask", PlayerLayer.Body, delegate (PlayerDrawInfo drawInfo)
		{
			if (drawInfo.shadow != 0f || drawInfo.drawPlayer.dead)
			{
				return;
			}
			Player drawPlayer = drawInfo.drawPlayer;
			Mod mod = ModLoader.GetMod("JourneyTrend");
			if (drawPlayer.body != mod.GetEquipSlot("NexusBody", EquipType.Body))
			{
				return;
			}
			Texture2D texture = mod.GetTexture("Items/Vanity/Nexus/NexusBody_FemaleGlow");
			if (drawPlayer.Male)
			{
				texture = mod.GetTexture("Items/Vanity/Nexus/NexusBody_Glow");
			}			
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

		public static readonly PlayerLayer NexusLegsGlowmask = new PlayerLayer("JourneyTrend", "NexusLegsGlowmask", PlayerLayer.Legs, delegate (PlayerDrawInfo drawInfo)
		{
			if (drawInfo.shadow != 0f || drawInfo.drawPlayer.dead)
			{
				return;
			}
			Player drawPlayer = drawInfo.drawPlayer;
			Mod mod = ModLoader.GetMod("JourneyTrend");
			if (drawPlayer.legs != mod.GetEquipSlot("NexusLegs", EquipType.Legs))
			{
				return;
			}
			Texture2D texture = mod.GetTexture("Items/Vanity/Nexus/NexusLegs_Glow");
			float drawX = (int)drawInfo.position.X + drawPlayer.width / 2;
			float drawY = (int)drawInfo.position.Y + drawPlayer.height - drawPlayer.legFrame.Height / 2 + 4f + 14f;
			Vector2 origin = drawInfo.legOrigin;
			Vector2 position = new Vector2(drawX, drawY) + drawPlayer.legPosition - Main.screenPosition;
			float alpha = (255 - drawPlayer.immuneAlpha) / 255f;
			Color color = new Color(255 * 100 / 100, 255 * 100 / 100, 255 * 100 / 100);
			Rectangle frame = drawPlayer.legFrame;
			float rotation = drawPlayer.legRotation;
			SpriteEffects spriteEffects = drawInfo.spriteEffects;
			DrawData drawData = new DrawData(texture, position, frame, color * alpha, rotation, origin, 1f, spriteEffects, 0);
			drawData.shader = drawInfo.legArmorShader;
			Main.playerDrawData.Add(drawData);
		});

		public static readonly PlayerLayer NexusArmsGlowmask = new PlayerLayer("JourneyTrend", "NexusArmsGlowmask", PlayerLayer.Arms, delegate (PlayerDrawInfo drawInfo)
		{
			if (drawInfo.shadow != 0f || drawInfo.drawPlayer.dead)
			{
				return;
			}
			Player drawPlayer = drawInfo.drawPlayer;
			Mod mod = ModLoader.GetMod("JourneyTrend");
			if (drawPlayer.legs != mod.GetEquipSlot("NexusBody", EquipType.Body))
			{
				return;
			}
			Texture2D texture = mod.GetTexture("Items/Vanity/Nexus/NexusBody_ArmsGlow");
			float drawX = (int)drawInfo.position.X + drawPlayer.width / 2;
			float drawY = (int)drawInfo.position.Y + drawPlayer.height - drawPlayer.bodyFrame.Height / 2 + 4f;
			Vector2 origin = drawInfo.bodyOrigin;
			Vector2 position = new Vector2(drawX, drawY) + drawPlayer.bodyPosition - Main.screenPosition;
			float alpha = (255 - drawPlayer.immuneAlpha) / 255f;
			Color color = new Color(255 * 100 / 100, 255 * 100 / 100, 255 * 100 / 100);
			Rectangle frame = drawPlayer.bodyFrame;
			float rotation = drawPlayer.bodyRotation;
			SpriteEffects spriteEffects = drawInfo.spriteEffects;
			DrawData drawData = new DrawData(texture, position, frame, color * alpha, rotation, origin, 1f, spriteEffects, 0);
			drawData.shader = drawInfo.bodyArmorShader;
			Main.playerDrawData.Add(drawData);
		});

		public static readonly PlayerLayer NightlightBodyGlowmask = new PlayerLayer("JourneyTrend", "NightlightBodyGlowmask", PlayerLayer.Body, delegate (PlayerDrawInfo drawInfo)
		{
			if (drawInfo.shadow != 0f || drawInfo.drawPlayer.dead)
			{
				return;
			}
			Player drawPlayer = drawInfo.drawPlayer;
			Mod mod = ModLoader.GetMod("JourneyTrend");
			if (drawPlayer.body != mod.GetEquipSlot("NightlightBody", EquipType.Body))
			{
				return;
			}
			Texture2D texture = mod.GetTexture("Items/Vanity/Nightlight/NightlightBody_Glow");
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
			if (foxTails)
			{
				int legsIndex = layers.IndexOf(PlayerLayer.Skin);
				layers.Insert(legsIndex - 1, NineTailedFoxTail);
			}
			int headLayer = layers.FindIndex(l => l == PlayerLayer.Head);
			int bodyLayer = layers.FindIndex(l => l == PlayerLayer.Body);
			int legsLayer = layers.FindIndex(l => l == PlayerLayer.Legs);
			if (headLayer > -1)
			{
				layers.Insert(headLayer + 1, ContainmentHeadGlowmask);
				layers.Insert(headLayer + 1, CyberAngelHeadGlowmask);
				layers.Insert(headLayer + 1, MushroomHeadGlowmask);
				layers.Insert(headLayer + 1, NexusHeadGlowmask);
			}
			if (bodyLayer > -1)
			{
				layers.Insert(bodyLayer + 1, ContainmentBodyGlowmask);
				layers.Insert(bodyLayer + 1, CyberAngelBodyGlowmask);
				layers.Insert(bodyLayer + 1, MushroomBodyGlowmask);
				layers.Insert(bodyLayer + 1, NexusBodyGlowmask);
				layers.Insert(bodyLayer + 1, NightlightBodyGlowmask);
				int armsLayer = layers.FindIndex(l => l == PlayerLayer.Arms);
				if (armsLayer > -1)
				{
					layers.Insert(armsLayer + 1, MushroomArmsGlowmask);
					layers.Insert(armsLayer + 1, NexusArmsGlowmask);
				}
			}
			if (legsLayer > -1)
			{
				layers.Insert(legsLayer + 1, CyberAngelLegsGlowmask);
				layers.Insert(legsLayer + 1, MushroomLegsGlowmask);
				layers.Insert(legsLayer + 1, NexusLegsGlowmask);
			}
		}
	}
}
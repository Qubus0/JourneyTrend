using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace JourneyTrend
{
    public class JourneyPlayer : ModPlayer
	{
		//starting Items
		public override void SetupStartInventory(IList<Item> items, bool mediumcoreDeath)
		{
			Item TravellerHead = new Item();
			TravellerHead.SetDefaults(ModContent.ItemType<Items.Vanity.Traveller.TravellerHead>());
			TravellerHead.stack = 1;
			items.Add(TravellerHead);

			Item TravellerBody = new Item();
			TravellerBody.SetDefaults(ModContent.ItemType<Items.Vanity.Traveller.TravellerBody>());
			TravellerBody.stack = 1;
			items.Add(TravellerBody);

			Item TravellerLegs = new Item();
			TravellerLegs.SetDefaults(ModContent.ItemType<Items.Vanity.Traveller.TravellerLegs>());
			TravellerLegs.stack = 1;
			items.Add(TravellerLegs);
		}


		//Idle Animating Fox Tails
		public bool FoxTailsEquipped;
		private int NineTailedTickToFrame;
		private int NineTailedFrameUpdater;
		private int NineTailedFrameCounter = 0;
		public bool NinetailedFlying;
		public static readonly PlayerLayer NineTailedFoxTail = new PlayerLayer("JourneyTrend", "NineTailedFoxTail", PlayerLayer.WaistAcc, delegate (PlayerDrawInfo drawInfo)
		{
			if (!drawInfo.drawPlayer.dead)
			{
				Player drawPlayer = drawInfo.drawPlayer;
				Mod mod = ModLoader.GetMod("JourneyTrend");
				JourneyPlayer modPlayer = drawPlayer.GetModPlayer<JourneyPlayer>();
				if (modPlayer.FoxTailsEquipped)
				{
					Rectangle? rectangle = new Rectangle(0, modPlayer.NineTailedFrameUpdater * 56, 46, 56);	//frame updater
					Color newColor = Lighting.GetColor((int)((drawInfo.position.X + drawPlayer.width / 2f) / 16f),
					(int)((drawInfo.position.Y + drawPlayer.height / 2f) / 16f));
					newColor = new Color(newColor.R, newColor.B, newColor.G, (int)((1 - drawPlayer.shadow) * 255));
					Texture2D texture = mod.GetTexture("Items/Vanity/NineTailedFox/NineTailedFoxAcc_Tails");
					int num = texture.Height / 11;
					int num2 = (int)(drawInfo.position.X + drawPlayer.width / 2f - Main.screenPosition.X - (3 * drawPlayer.direction)); //has offset of -3 px
					int num3 = (int)(drawInfo.position.Y + drawPlayer.height / 2f - Main.screenPosition.Y - 3f);
					DrawData item = new DrawData(texture, new Vector2(num2, num3), rectangle,
					newColor, 0f, new Vector2(texture.Width / 2f, num / 2f), 1f, drawInfo.spriteEffects, 0)
					{
						shader = drawPlayer.cWings              //wing acc -> wing shader (c...)
					};
					Main.playerDrawData.Add(item);
				}
			}
		});




		//accessory type capes (not idle animated)
		private static Rectangle playerframe;       //grabs playerframe for all below
		private bool isIdle;						//true if not moving

		public bool StarlightBodyEquipped;        //corresponding equip bool
        public static readonly PlayerLayer StarlightDreamScarf = new PlayerLayer("JourneyTrend", "StarlightDreamScarf", PlayerLayer.BackAcc, delegate (PlayerDrawInfo drawInfo)
        {									//name here same as name								here.	Needs correct accesory here as well
            if (!drawInfo.drawPlayer.dead)
            {
                Player drawPlayer = drawInfo.drawPlayer;
                Mod mod = ModLoader.GetMod("JourneyTrend");
                JourneyPlayer modPlayer = drawPlayer.GetModPlayer<JourneyPlayer>();
                if (modPlayer.StarlightBodyEquipped)			//needs coorect equip bool
                {
					Rectangle? rectangle = playerframe;	//updates rect here
                    Color newColor = Lighting.GetColor((int)((drawInfo.position.X + drawPlayer.width / 2f) / 16f),
                    (int)((drawInfo.position.Y + drawPlayer.height / 2f) / 16f));
                    newColor = new Color(newColor.R, newColor.B, newColor.G, (int)((1 - drawPlayer.shadow) * 255));
                    Texture2D texture = mod.GetTexture("Items/Vanity/StarlightDream/StarlightDreamAcc_Back");	//needs correct sprite path
                    int num = texture.Height / 20;				//20 -> number of frames
                    int num2 = (int)(drawInfo.position.X + drawPlayer.width / 2f - Main.screenPosition.X);		//no offset from player rect
					int num3 = (int)(drawInfo.position.Y + drawPlayer.height / 2f - Main.screenPosition.Y - 3f);
                    DrawData item = new DrawData(texture, new Vector2(num2, num3), rectangle,
                    newColor, 0f, new Vector2(texture.Width / 2f, num / 2f), 1f, drawInfo.spriteEffects, 0)
                    {
                        shader = drawPlayer.cBody				//part of body -> body shader (c...)
                    };
                    Main.playerDrawData.Add(item);
                }
            }
        });         //don't forget to change ModifyDrawlayers at the bottom

		


		public bool KnightwalkerHeadEquipped;
		private int KnightwalkerHeadTickToFrame;
		private int KnightwalkerHeadFrameUpdater;
		private int KnightwalkerHeadFrameCounter = 0;
		public static readonly PlayerLayer KnightwalkerHeadAddons = new PlayerLayer("JourneyTrend", "KnightwalkerHeadAddons", PlayerLayer.Head, delegate (PlayerDrawInfo drawInfo)
		{
			if (!drawInfo.drawPlayer.dead)
			{
				Player drawPlayer = drawInfo.drawPlayer;
				Mod mod = ModLoader.GetMod("JourneyTrend");
				JourneyPlayer modPlayer = drawPlayer.GetModPlayer<JourneyPlayer>();
				if (modPlayer.KnightwalkerHeadEquipped)
				{
					Texture2D texture = mod.GetTexture("Items/Vanity/Knightwalker/KnightwalkerHeadflame_Idle");   //needs correct sprite path
					int num = texture.Height / 8;              //8 -> number of frames
					Rectangle? rectangle = new Rectangle(0, modPlayer.KnightwalkerHeadFrameUpdater * num, texture.Width, num);    //frame updater
					Color color = Color.White;
					int num2 = (int)(drawInfo.position.X + drawPlayer.width / 2f - Main.screenPosition.X + drawPlayer.direction);
					int num3 = (int)(drawInfo.position.Y + drawPlayer.height / 2f - Main.screenPosition.Y-27f);
					DrawData item = new DrawData(texture, new Vector2(num2, num3), rectangle,
					color, 0f, new Vector2(texture.Width / 2f, num / 2f), 1f, drawInfo.spriteEffects, 0)
					{
						shader = drawPlayer.cHead              //use correct shader (c...)
					};
					Main.playerDrawData.Add(item);
				}
			}
		});



		public bool KnightwalkerBodyEquipped;           //corresponding equip bool
		public bool KnightwalkerAlt;
		private int KnightwalkerFlameTickToFrame;
		private int KnightwalkerFlameFrameUpdater;
		private int KnightwalkerFlameFrameCounter = 0;
		private int KnightwalkerCapeTickToFrame;
		private int KnightwalkerCapeFrameUpdater;
		private int KnightwalkerCapeFrameCounter = 0;
		public static readonly PlayerLayer KnightwalkerBodyAddons = new PlayerLayer("JourneyTrend", "KnightwalkerBodyAddons", PlayerLayer.BackAcc, delegate (PlayerDrawInfo drawInfo)
		{                                   //name here same as name								here.	Needs correct accesory here as well
			if (!drawInfo.drawPlayer.dead)
			{
				Player drawPlayer = drawInfo.drawPlayer;
				Mod mod = ModLoader.GetMod("JourneyTrend");
				JourneyPlayer modPlayer = drawPlayer.GetModPlayer<JourneyPlayer>();
				if (modPlayer.KnightwalkerBodyEquipped)           //needs coorect equip bool
				{
					Texture2D texture = mod.GetTexture("Items/Vanity/Knightwalker/KnightwalkerCape_Idle");   //needs correct sprite path
					int num = texture.Height / 21;              //21 -> number of frames
					Rectangle? rectangle = new Rectangle(0, modPlayer.KnightwalkerCapeFrameUpdater * num, texture.Width, num);    //frame updater
					Color color = Lighting.GetColor((int)((drawInfo.position.X + drawPlayer.width / 2f) / 16f),
					(int)((drawInfo.position.Y + drawPlayer.height / 2f) / 16f));
					color = new Color(color.R, color.B, color.G, (int)((1 - drawPlayer.shadow) * 255));
					int num2 = (int)(drawInfo.position.X + drawPlayer.width / 2f - Main.screenPosition.X - (6 * drawPlayer.direction));
					int num3 = (int)(drawInfo.position.Y + drawPlayer.height / 2f - Main.screenPosition.Y + 7f);
					DrawData item = new DrawData(texture, new Vector2(num2, num3), rectangle,
					color, 0f, new Vector2(texture.Width / 2f, num / 2f), 1f, drawInfo.spriteEffects, 0)
					{
						shader = drawPlayer.cBody               //use correct shader (c...)
					};
					Main.playerDrawData.Add(item);
				}
				if (modPlayer.KnightwalkerBodyEquipped)           //needs coorect equip bool
				{
					Rectangle? rectangle = playerframe; //updates rect here
					Color color = Lighting.GetColor((int)((drawInfo.position.X + drawPlayer.width / 2f) / 16f),	// ) replace these 3 lines
					(int)((drawInfo.position.Y + drawPlayer.height / 2f) / 16f));								// ) with Color color = Color.White;
					color = new Color(color.R, color.B, color.G, (int)((1 - drawPlayer.shadow) * 255));			// ) for glowmask
					Texture2D texture = mod.GetTexture("Items/Vanity/Knightwalker/KnightwalkerBodyAcc_Back");   //needs correct sprite path
					int num = texture.Height / 20;              //20 -> number of frames
					int num2 = (int)(drawInfo.position.X + drawPlayer.width / 2f - Main.screenPosition.X);      //no offset from player rect
					int num3 = (int)(drawInfo.position.Y + drawPlayer.height / 2f - Main.screenPosition.Y - 3f);
					DrawData item = new DrawData(texture, new Vector2(num2, num3), rectangle,
					color, 0f, new Vector2(texture.Width / 2f, num / 2f), 1f, drawInfo.spriteEffects, 0)
					{
						shader = drawPlayer.cBody               //use correct shader (c...)
					};
					Main.playerDrawData.Add(item);
				}

				if (modPlayer.KnightwalkerBodyEquipped)           //needs coorect equip bool
				{
					Texture2D texture;
                    if (!modPlayer.KnightwalkerAlt)
                    {
						texture = mod.GetTexture("Items/Vanity/Knightwalker/KnightwalkerBodyflame_Idle");   //needs correct sprite path
					} else {
						texture = mod.GetTexture("Items/Vanity/Knightwalker/KnightwalkerBodyflame_Idle1");
					}
					int num = texture.Height / 8;              //8 -> number of frames
					Rectangle? rectangle = new Rectangle(0, modPlayer.KnightwalkerFlameFrameUpdater * num, texture.Width, num);    //frame updater
					Color color = Color.White;
					int num2 = (int)(drawInfo.position.X + drawPlayer.width / 2f - Main.screenPosition.X - (2 * drawPlayer.direction));
					int num3 = (int)(drawInfo.position.Y + drawPlayer.height / 2f - Main.screenPosition.Y - 14f);
					DrawData item = new DrawData(texture, new Vector2(num2, num3), rectangle,
					color, 0f, new Vector2(texture.Width / 2f, num / 2f), 1f, drawInfo.spriteEffects, 0)
					{
						shader = drawPlayer.cBody               //use correct shader (c...)
					};
					Main.playerDrawData.Add(item);
				}
			}
		});         //don't forget to change ModifyDrawlayers at the bottom





		public override void PreUpdate()
		{
			if (player.velocity == Vector2.Zero)
            {
				isIdle = true;
			} else
            {
				isIdle = false;
			}

			if (StarlightBodyEquipped)						
			{
				playerframe = player.bodyFrame;        //grabs player rect
			}

            if (KnightwalkerBodyEquipped)
            {

				if (player.grapCount > 0 && !isIdle) //when grappling and not not moving (grappled still)
				{
					playerframe = new Rectangle(0, 6 * (1120/20), 40, 1120/20);
				}
				else
                {
					playerframe = player.bodyFrame;        //grabs player rect
				}
			}


			if (KnightwalkerBodyEquipped)
			{
				KnightwalkerFlameTickToFrame++;
				if (KnightwalkerFlameTickToFrame == 5)             //every 5 ticks update
				{
					KnightwalkerFlameFrameCounter++;               //next frame
					if (KnightwalkerFlameFrameCounter >= 8)       //loop all frames from 0 to 7
					{
						KnightwalkerFlameFrameCounter = 0;         //reset to first frame
					}
					KnightwalkerFlameTickToFrame = 0;              //reset tick counter
				}
				if (isIdle)
				{
					KnightwalkerCapeTickToFrame++;
					if (KnightwalkerCapeTickToFrame == 8)             //every 8 ticks update
					{
						KnightwalkerCapeFrameCounter++;               //next frame
						if (KnightwalkerCapeFrameCounter >= 20)       //loop all frames from 0 to 20
						{
							KnightwalkerCapeFrameCounter = 0;         //reset to first frame
						}
						KnightwalkerCapeTickToFrame = 0;              //reset tick counter
					}
				} else {
					KnightwalkerCapeFrameCounter = 21;  //set to empty frame when moving
				}		
			}
			KnightwalkerFlameFrameUpdater = KnightwalkerFlameFrameCounter;
			KnightwalkerCapeFrameUpdater = KnightwalkerCapeFrameCounter;


			if (KnightwalkerHeadEquipped)
			{
				KnightwalkerHeadTickToFrame++;
				if (KnightwalkerHeadTickToFrame == 5)             //every 5 ticks update
				{
					KnightwalkerHeadFrameCounter++;               //next frame
					if (KnightwalkerHeadFrameCounter >= 8)		//loop all frames from 0 to 7
					{
						KnightwalkerHeadFrameCounter = 0;         //reset to first frame
					}
					KnightwalkerHeadTickToFrame = 0;              //reset tick counter
				}
			}
			KnightwalkerHeadFrameUpdater = KnightwalkerHeadFrameCounter;


			if (FoxTailsEquipped)							//foxTailsEquipped gets updated in NineTailedFoxAcc.cs
				{
				NineTailedTickToFrame++;
				if (NineTailedTickToFrame == 8)				//every 8 ticks update
				{
					NineTailedFrameCounter++;				//next frame
					if (NineTailedFrameCounter >= 10)		//loop all frames from 0 to 9
					{
						NineTailedFrameCounter = 0;			//reset to first frame
					}
					NineTailedTickToFrame = 0;				//reset tick counter
				}
				if (!NinetailedFlying) { NineTailedFrameUpdater = NineTailedFrameCounter; }	//set counter to updater
				else { NineTailedFrameUpdater = 10; }							//use frame 10 when flying
			}
		}


		public bool doOffset;		//used for the rookie hand offset (because it is lower than normal)
		public override void ResetEffects()	//reset all the equip type bools
		{
			FoxTailsEquipped = false;
			NinetailedFlying = false;
            StarlightBodyEquipped = false;
			KnightwalkerBodyEquipped = false;
			KnightwalkerHeadEquipped = false;
			isIdle = false;
		}








		//Glowmask business
		public static readonly PlayerLayer ContainmentSuitHeadGlowmask = new PlayerLayer("JourneyTrend", "ContainmentSuitHeadGlowmask", PlayerLayer.Head, delegate (PlayerDrawInfo drawInfo)
		{
			if (drawInfo.shadow != 0f || drawInfo.drawPlayer.dead)
			{
				return;
			}
			Player drawPlayer = drawInfo.drawPlayer;
			Mod mod = ModLoader.GetMod("JourneyTrend");
			if (drawPlayer.head != mod.GetEquipSlot("ContainmentSuitHead", EquipType.Head))
			{
				return;
			}
			Texture2D texture = mod.GetTexture("Items/Vanity/ContainmentSuit/ContainmentSuitHead_Glowmask");
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

		public static readonly PlayerLayer ContainmentSuitBodyGlowmask = new PlayerLayer("JourneyTrend", "ContainmentSuitBodyGlowmask", PlayerLayer.Body, delegate (PlayerDrawInfo drawInfo)
		{
			if (drawInfo.shadow != 0f || drawInfo.drawPlayer.dead)
			{
				return;
			}
			Player drawPlayer = drawInfo.drawPlayer;
			Mod mod = ModLoader.GetMod("JourneyTrend");
			if (drawPlayer.body != mod.GetEquipSlot("ContainmentSuitBody", EquipType.Body))
			{
				return;
			}
			Texture2D texture = mod.GetTexture("Items/Vanity/ContainmentSuit/ContainmentSuitBody_Glowmask");
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

		public static readonly PlayerLayer KnighwalkerHeadGlowmask = new PlayerLayer("JourneyTrend", "KnighwalkerHeadGlowmask", PlayerLayer.Head, delegate (PlayerDrawInfo drawInfo)
		{
			if (drawInfo.shadow != 0f || drawInfo.drawPlayer.dead)
			{
				return;
			}
			Player drawPlayer = drawInfo.drawPlayer;
			Mod mod = ModLoader.GetMod("JourneyTrend");
			if (drawPlayer.head != mod.GetEquipSlot("KnightwalkerHead", EquipType.Head))
			{
				return;
			}
			Texture2D texture = mod.GetTexture("Items/Vanity/Knightwalker/KnightwalkerHead_Glow");
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


		public override void ModifyDrawLayers(List<PlayerLayer> layers)
		{
			if (FoxTailsEquipped)
			{
				int legsIndex = layers.IndexOf(PlayerLayer.Skin);
				layers.Insert(legsIndex - 1, NineTailedFoxTail);
			}

			if (StarlightBodyEquipped)
			{
				int legsIndex = layers.IndexOf(PlayerLayer.Skin);
				layers.Insert(legsIndex - 1, StarlightDreamScarf);
			}

			if (KnightwalkerHeadEquipped)
			{
				int legsIndex = layers.IndexOf(PlayerLayer.Skin);
				layers.Insert(legsIndex - 1, KnightwalkerHeadAddons);
			}

			if (KnightwalkerBodyEquipped)
			{
				int legsIndex = layers.IndexOf(PlayerLayer.Skin);
				layers.Insert(legsIndex - 1, KnightwalkerBodyAddons);
			}


			int headLayer = layers.FindIndex(l => l == PlayerLayer.Head);
			int bodyLayer = layers.FindIndex(l => l == PlayerLayer.Body);
			int legsLayer = layers.FindIndex(l => l == PlayerLayer.Legs);
			if (headLayer > -1)
			{
				layers.Insert(headLayer + 1, ContainmentSuitHeadGlowmask);
				layers.Insert(headLayer + 1, CyberAngelHeadGlowmask);
				layers.Insert(headLayer + 1, MushroomHeadGlowmask);
				layers.Insert(headLayer + 1, NexusHeadGlowmask);
				layers.Insert(headLayer + 1, KnighwalkerHeadGlowmask);
			}
			if (bodyLayer > -1)
			{
				layers.Insert(bodyLayer + 1, ContainmentSuitBodyGlowmask);
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

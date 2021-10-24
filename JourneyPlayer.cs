using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using JourneyTrend.Items.Vanity.Traveller;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyTrend
{
    public class JourneyPlayer : ModPlayer
    {
        // todo, reference for draw layer reimplementation

        // public static readonly PlayerLayer StarlightDreamScarf = new PlayerLayer("JourneyTrend", "StarlightDreamScarf",
        //     PlayerLayer.BackAcc, delegate(PlayerDrawSet drawInfo)
        //     {
        //         if (!drawInfo.drawPlayer.dead)
        //         {
        //             var drawPlayer = drawInfo.drawPlayer;
        //             ModLoader.TryGetMod("JourneyTrend", out Mod mod);
        //             var modPlayer = drawPlayer.GetModPlayer<JourneyPlayer>();
        //             if (modPlayer.StarlightBodyEquipped) //needs correct equip bool
        //             {
        //                 Rectangle? rectangle = _playerFrame; //updates rect here
        //                 var newColor = Lighting.GetColor((int) ((drawInfo.Position.X + drawPlayer.width / 2f) / 16f),
        //                     (int) ((drawInfo.Position.Y + drawPlayer.height / 2f) / 16f));
        //                 newColor = new Color(newColor.R, newColor.B, newColor.G, (int) ((1 - drawPlayer.shadow) * 255));
        //                 var texture =
        //                     Request<Texture2D>(
        //                         "Items/Vanity/StarlightDream/StarlightDreamAcc_Back").Value; //needs correct sprite path
        //                 var num = texture.Height / 20; //20 -> number of frames
        //                 var num2 = (int) (drawInfo.Position.X + drawPlayer.width / 2f -
        //                                   Main.screenPosition.X); //no offset from player rect
        //                 var num3 = (int) (drawInfo.Position.Y + drawPlayer.height / 2f - Main.screenPosition.Y - 3f +
        //                                   modPlayer.walkUpShift);
        //                 var item = new DrawData(texture, new Vector2(num2, num3), rectangle,
        //                     newColor, 0f, new Vector2(texture.Width/ 2f, num / 2f), 1f, drawInfo.spriteEffects, 0)
        //                 {
        //                     shader = drawPlayer.cBody //part of body -> body shader (c...)
        //                 };
        //                 Main.playerDrawData.Add(item);
        //             }
        //         }
        //     }); //don't forget to change ModifyDrawlayers at the bottom
        //
        // public static readonly PlayerLayer StarlightDreamScarfGlow = new PlayerLayer("JourneyTrend",
        //     "StarlightDreamScarfGlow", PlayerLayer.BackAcc, delegate(PlayerDrawSet drawInfo)
        //     {
        //         //name here same as name								here.	Needs correct accessory here as well
        //         if (!drawInfo.drawPlayer.dead)
        //         {
        //             var drawPlayer = drawInfo.drawPlayer;
        //             ModLoader.TryGetMod("JourneyTrend", out Mod mod);
        //             var modPlayer = drawPlayer.GetModPlayer<JourneyPlayer>();
        //             if (modPlayer.StarlightBodyEquipped) //needs correct equip bool
        //             {
        //                 Rectangle? rectangle = _playerFrame; //updates rect here
        //                 var newColor = Color.White;
        //                 var texture =
        //                     Request<Texture2D>(
        //                         "Items/Vanity/StarlightDream/StarlightDreamAcc_Glow").Value; //needs correct sprite path
        //                 var num = texture.Height / 20; //20 -> number of frames
        //                 var num2 = (int) (drawInfo.Position.X + drawPlayer.width / 2f -
        //                                   Main.screenPosition.X); //no offset from player rect
        //                 var num3 = (int) (drawInfo.Position.Y + drawPlayer.height / 2f - Main.screenPosition.Y - 3f +
        //                                   modPlayer.walkUpShift);
        //                 var item = new DrawData(texture, new Vector2(num2, num3), rectangle,
        //                     newColor, 0f, new Vector2(texture.Width / 2f, num / 2f), 1f, drawInfo.spriteEffects, 0)
        //                 {
        //                     shader = drawPlayer.cBody //part of body -> body shader (c...)
        //                 };
        //                 Main.playerDrawData.Add(item);
        //             }
        //         }
        //     }); //don't forget to change ModifyDrawlayers at the bottom
        //
        // public static readonly PlayerLayer KnightwalkerHeadAddons = new PlayerLayer("JourneyTrend",
        //     "KnightwalkerHeadAddons", PlayerLayer.Head, delegate(PlayerDrawSet drawInfo)
        //     {
        //         if (!drawInfo.drawPlayer.dead)
        //         {
        //             var drawPlayer = drawInfo.drawPlayer;
        //             ModLoader.TryGetMod("JourneyTrend", out Mod mod);
        //             var modPlayer = drawPlayer.GetModPlayer<JourneyPlayer>();
        //             if (modPlayer.KnightwalkerHeadEquipped)
        //             {
        //                 var texture =
        //                     Request<Texture2D>(
        //                         "Items/Vanity/Knightwalker/KnightwalkerHeadflame_Idle").Value; //needs correct sprite path
        //                 var num = texture.Height / 8; //8 -> number of frames
        //                 Rectangle? rectangle = new Rectangle(0, modPlayer.KnightwalkerHeadFrameUpdater * num,
        //                     texture.Width, num); //frame updater
        //                 var color = Color.White;
        //                 var num2 = (int) (drawInfo.position.X + drawPlayer.width / 2f - Main.screenPosition.X +
        //                                   drawPlayer.direction);
        //                 var num3 = (int) (drawInfo.position.Y + drawPlayer.height / 2f - Main.screenPosition.Y - 27f +
        //                                   modPlayer.walkUpShift);
        //                 var item = new DrawData(texture, new Vector2(num2, num3), rectangle,
        //                     color, 0f, new Vector2(texture.Width / 2f, num / 2f), 1f, drawInfo.spriteEffects, 0)
        //                 {
        //                     shader = drawPlayer.cHead //use correct shader (c...)
        //                 };
        //                 Main.playerDrawData.Add(item);
        //             }
        //         }
        //     });
        //
        // public static readonly PlayerLayer KnightwalkerBodyAddons = new PlayerLayer("JourneyTrend",
        //     "KnightwalkerBodyAddons", PlayerLayer.BackAcc, delegate(PlayerDrawSet drawInfo)
        //     {
        //         //name here same as name								here.	Needs correct accessory here as well
        //         if (!drawInfo.drawPlayer.dead)
        //         {
        //             var drawPlayer = drawInfo.drawPlayer;
        //             ModLoader.TryGetMod("JourneyTrend", out Mod mod);
        //             var modPlayer = drawPlayer.GetModPlayer<JourneyPlayer>();
        //             if (modPlayer.KnightwalkerBodyEquipped) //needs correct equip bool
        //             {
        //                 var texture =
        //                     Request<Texture2D>(
        //                         "Items/Vanity/Knightwalker/KnightwalkerCape_Idle").Value; //needs correct sprite path
        //                 var num = texture.Height / 21; //21 -> number of frames
        //                 Rectangle? rectangle = new Rectangle(0, modPlayer.KnightwalkerCapeFrameUpdater * num,
        //                     texture.Width, num); //frame updater
        //                 var color = Lighting.GetColor((int) ((drawInfo.position.X + drawPlayer.width / 2f) / 16f),
        //                     (int) ((drawInfo.position.Y + drawPlayer.height / 2f) / 16f));
        //                 color = new Color(color.R, color.B, color.G, (int) ((1 - drawPlayer.shadow) * 255));
        //                 var num2 = (int) (drawInfo.position.X + drawPlayer.width / 2f - Main.screenPosition.X -
        //                                   6 * drawPlayer.direction);
        //                 var num3 = (int) (drawInfo.position.Y + drawPlayer.height / 2f - Main.screenPosition.Y + 7f +
        //                                   modPlayer.walkUpShift);
        //                 var item = new DrawData(texture, new Vector2(num2, num3), rectangle,
        //                     color, 0f, new Vector2(texture.Width / 2f, num / 2f), 1f, drawInfo.spriteEffects, 0)
        //                 {
        //                     shader = drawPlayer.cBody //use correct shader (c...)
        //                 };
        //                 Main.playerDrawData.Add(item);
        //             }
        //
        //             if (modPlayer.KnightwalkerBodyEquipped) //needs correct equip bool
        //             {
        //                 Rectangle? rectangle = _playerFrame; //updates rect here
        //                 var color = Lighting.GetColor(
        //                     (int) ((drawInfo.position.X + drawPlayer.width / 2f) / 16f), // ) replace these 3 lines
        //                     (int) ((drawInfo.position.Y + drawPlayer.height / 2f) /
        //                            16f)); // ) with Color color = Color.White;
        //                 color = new Color(color.R, color.B, color.G,
        //                     (int) ((1 - drawPlayer.shadow) * 255)); // ) for glowmask
        //                 var texture =
        //                     Request<Texture2D>(
        //                         "Items/Vanity/Knightwalker/KnightwalkerBodyAcc_Back").Value; //needs correct sprite path
        //                 var num = texture.Height / 20; //20 -> number of frames
        //                 var num2 = (int) (drawInfo.position.X + drawPlayer.width / 2f -
        //                                   Main.screenPosition.X); //no offset from player rect
        //                 var num3 = (int) (drawInfo.position.Y + drawPlayer.height / 2f - Main.screenPosition.Y - 3f +
        //                                   modPlayer.walkUpShift);
        //                 var item = new DrawData(texture, new Vector2(num2, num3), rectangle,
        //                     color, 0f, new Vector2(texture.Width / 2f, num / 2f), 1f, drawInfo.spriteEffects, 0)
        //                 {
        //                     shader = drawPlayer.cBody //use correct shader (c...)
        //                 };
        //                 Main.playerDrawData.Add(item);
        //             }
        //
        //             if (modPlayer.KnightwalkerBodyEquipped) //needs correct equip bool
        //             {
        //                 Texture2D texture;
        //                 if (!modPlayer.KnightwalkerAlt)
        //                     texture = Request<Texture2D>(
        //                         "Items/Vanity/Knightwalker/KnightwalkerBodyflame_Idle").Value; //needs correct sprite path
        //                 else
        //                     texture = Request<Texture2D>("Items/Vanity/Knightwalker/KnightwalkerBodyflame_Idle1").Value;
        //                 var num = texture.Height / 8; //8 -> number of frames
        //                 Rectangle? rectangle = new Rectangle(0, modPlayer.KnightwalkerFlameFrameUpdater * num,
        //                     texture.Width, num); //frame updater
        //                 var color = Color.White;
        //                 var num2 = (int) (drawInfo.position.X + drawPlayer.width / 2f - Main.screenPosition.X -
        //                                   2 * drawPlayer.direction);
        //                 var num3 = (int) (drawInfo.position.Y + drawPlayer.height / 2f - Main.screenPosition.Y - 14f +
        //                                   modPlayer.walkUpShift);
        //                 var item = new DrawData(texture, new Vector2(num2, num3), rectangle,
        //                     color, 0f, new Vector2(texture.Width / 2f, num / 2f), 1f, drawInfo.spriteEffects, 0)
        //                 {
        //                     shader = drawPlayer.cBody //use correct shader (c...)
        //                 };
        //                 Main.playerDrawData.Add(item);
        //             }
        //         }
        //     }); //don't forget to change ModifyDrawlayers at the bottom
        //
        // public static readonly PlayerLayer BubbleheadHeadAddons = new PlayerLayer("JourneyTrend",
        //     "BubbleheadHeadAddons", PlayerLayer.Head, delegate(PlayerDrawSet drawInfo)
        //     {
        //         if (!drawInfo.drawPlayer.dead)
        //         {
        //             var drawPlayer = drawInfo.drawPlayer;
        //             ModLoader.TryGetMod("JourneyTrend", out Mod mod);
        //             var modPlayer = drawPlayer.GetModPlayer<JourneyPlayer>();
        //             if (modPlayer.BubbleheadHeadEquipped)
        //             {
        //                 var texture =
        //                     Request<Texture2D>("Items/Vanity/Bubblehead/BubbleheadHead_Idle").Value; //needs correct sprite path
        //                 var num = texture.Height / 14; //14 -> number of frames
        //                 Rectangle? rectangle = new Rectangle(0, modPlayer.BubbleheadHeadFrameUpdater * num,
        //                     texture.Width, num); //frame updater
        //                 var color = Lighting.GetColor(
        //                     (int) ((drawInfo.position.X + drawPlayer.width / 2f) / 16f), // ) replace these 3 lines
        //                     (int) ((drawInfo.position.Y + drawPlayer.height / 2f) /
        //                            16f)); // ) with Color color = Color.White;
        //                 color = new Color(color.R, color.B, color.G,
        //                     (int) ((1 - drawPlayer.shadow) * 255)); // ) for glowmask
        //                 var num2 = (int) (drawInfo.position.X + drawPlayer.width / 2f - Main.screenPosition.X +
        //                                   drawPlayer.direction);
        //                 var num3 = (int) (drawInfo.position.Y + drawPlayer.height / 2f - Main.screenPosition.Y - 14f +
        //                                   modPlayer.walkUpShift);
        //                 var item = new DrawData(texture, new Vector2(num2, num3), rectangle,
        //                     color, 0f, new Vector2(texture.Width / 2f, num / 2f), 1f, drawInfo.spriteEffects, 0)
        //                 {
        //                     shader = drawPlayer.cHead //use correct shader (c...)
        //                 };
        //                 Main.playerDrawData.Add(item);
        //             }
        //         }
        //     }); //don't forget to change ModifyDrawlayers at the bottom
        // public static readonly PlayerLayer PlanetaryHeadAddons = new PlayerLayer("JourneyTrend", "PlanetaryHeadAddons",
        //     PlayerLayer.Head, delegate(PlayerDrawSet drawInfo)
        //     {
        //         if (!drawInfo.drawPlayer.dead)
        //         {
        //             Player drawPlayer = drawInfo.drawPlayer;
        //             Mod mod = ModLoader.ModLoader.TryGetMod("JourneyTrend", out Mod mod);("JourneyTrend");
        //             JourneyPlayer modPlayer = drawPlayer.GetModPlayer<JourneyPlayer>();
        //             if (modPlayer.PlanetaryHeadEquipped)
        //             {
        //                 Texture2D texture =
        //                     Request<Texture2D>(
        //                         "Items/Vanity/Planetary/PlanetaryHeadRingBack_Idle").Value; //needs correct sprite path
        //                 int num = texture.Height / 4; //4 -> number of frames
        //                 Rectangle? rectangle = new Rectangle(0, modPlayer.PlanetaryHeadRingFrameUpdater * num,
        //                     texture.Width, num); //frame updater
        //                 Color color = Lighting.GetColor(
        //                     (int) ((drawInfo.position.X + drawPlayer.width / 2f) / 16f), // ) replace these 3 lines
        //                     (int) ((drawInfo.position.Y + drawPlayer.height / 2f) /
        //                            16f)); // ) with Color color = Color.White;
        //                 color = new Color(color.R, color.B, color.G,
        //                     (int) ((1 - drawPlayer.shadow) * 255)); // ) for glowmask
        //                 int num2 = (int) (drawInfo.position.X + drawPlayer.width / 2f - Main.screenPosition.X +
        //                                   drawPlayer.direction);
        //                 int num3 = (int) (drawInfo.position.Y + drawPlayer.height / 2f - Main.screenPosition.Y - 11f +
        //                                   modPlayer.walkUpShift);
        //                 DrawData item = new DrawData(texture, new Vector2(num2, num3), rectangle,
        //                     color, 0f, new Vector2(texture.Width / 2f, num / 2f), 1f, drawInfo.spriteEffects, 0)
        //                 {
        //                     shader = drawPlayer.cHead //use correct shader (c...)
        //                 };
        //                 Main.playerDrawData.Add(item);
        //             }
        //
        //             if (modPlayer.PlanetaryHeadEquipped)
        //             {
        //                 Texture2D texture =
        //                     Request<Texture2D>(
        //                         "Items/Vanity/Planetary/PlanetaryHeadWater_Idle").Value; //needs correct sprite path
        //                 int num = texture.Height / 4; //4 -> number of frames
        //                 Rectangle? rectangle = new Rectangle(0, modPlayer.PlanetaryHeadWaterFrameUpdater * num,
        //                     texture.Width, num); //frame updater
        //                 Color color = Lighting.GetColor(
        //                     (int) ((drawInfo.position.X + drawPlayer.width / 2f) / 16f), // ) replace these 3 lines
        //                     (int) ((drawInfo.position.Y + drawPlayer.height / 2f) /
        //                            16f)); // ) with Color color = Color.White;
        //                 color = new Color(color.R, color.B, color.G,
        //                     (int) ((1 - drawPlayer.shadow) * 255)); // ) for glowmask
        //                 int num2 = (int) (drawInfo.position.X + drawPlayer.width / 2f - Main.screenPosition.X +
        //                                   drawPlayer.direction);
        //                 int num3 = (int) (drawInfo.position.Y + drawPlayer.height / 2f - Main.screenPosition.Y - 11f +
        //                                   modPlayer.walkUpShift);
        //                 DrawData item = new DrawData(texture, new Vector2(num2, num3), rectangle,
        //                     color, 0f, new Vector2(texture.Width / 2f, num / 2f), 1f, drawInfo.spriteEffects, 0)
        //                 {
        //                     shader = drawPlayer.cHead //use correct shader (c...)
        //                 };
        //                 Main.playerDrawData.Add(item);
        //             }
        //         }
        //     }); //don't forget to change ModifyDrawlayers at the bottom
        //
        // public static readonly PlayerLayer PlanetaryHeadAddonsFront = new PlayerLayer("JourneyTrend",
        //     "PlanetaryHeadAddonsFront", PlayerLayer.Head, delegate(PlayerDrawSet drawInfo)
        //     {
        //         if (!drawInfo.drawPlayer.dead)
        //         {
        //             Player drawPlayer = drawInfo.drawPlayer;
        //             Mod mod = ModLoader.ModLoader.TryGetMod("JourneyTrend", out Mod mod);("JourneyTrend");
        //             JourneyPlayer modPlayer = drawPlayer.GetModPlayer<JourneyPlayer>();
        //             if (modPlayer.PlanetaryHeadEquipped)
        //             {
        //                 Texture2D texture =
        //                     Request<Texture2D>(
        //                         "Items/Vanity/Planetary/PlanetaryHeadRingFront_Idle").Value; //needs correct sprite path
        //                 int num = texture.Height / 4; //4 -> number of frames
        //                 Rectangle? rectangle = new Rectangle(0, modPlayer.PlanetaryHeadRingFrameUpdater * num,
        //                     texture.Width, num); //frame updater
        //                 Color color = Lighting.GetColor(
        //                     (int) ((drawInfo.position.X + drawPlayer.width / 2f) / 16f), // ) replace these 3 lines
        //                     (int) ((drawInfo.position.Y + drawPlayer.height / 2f) /
        //                            16f)); // ) with Color color = Color.White;
        //                 color = new Color(color.R, color.B, color.G,
        //                     (int) ((1 - drawPlayer.shadow) * 255)); // ) for glowmask
        //                 int num2 = (int) (drawInfo.position.X + drawPlayer.width / 2f - Main.screenPosition.X +
        //                                   drawPlayer.direction);
        //                 int num3 = (int) (drawInfo.position.Y + drawPlayer.height / 2f - Main.screenPosition.Y - 11f +
        //                                   modPlayer.walkUpShift);
        //                 DrawData item = new DrawData(texture, new Vector2(num2, num3), rectangle,
        //                     color, 0f, new Vector2(texture.Width / 2f, num / 2f), 1f, drawInfo.spriteEffects, 0)
        //                 {
        //                     shader = drawPlayer.cHead //use correct shader (c...)
        //                 };
        //                 Main.playerDrawData.Add(item);
        //             }
        //         }
        //     });
        
        // Starting Items
        public override IEnumerable<Item> AddStartingItems(bool mediumCoreDeath)
        {
            return new[]
            {
                new Item(ItemType<TravellerHead>()),
                new Item(ItemType<TravellerBody>()),
                new Item(ItemType<TravellerLegs>()),
            };
        }

        public int walkUpShift; //-2 when the walk cycle has 'up' frames
        private bool isIdle; //true if not moving
        private bool isJumping; //true if the 6th player frame (jump) is used
        public bool doOffset; //used for the rookie hand offset (because it is lower than normal)

        public bool BubbleheadHeadEquipped;
        private int BubbleheadHeadFrameCounter;
        private int BubbleheadHeadFrameUpdater;
        private int BubbleheadHeadTickToFrame;

        public bool PlanetaryHeadEquipped;
        private int PlanetaryHeadRingTickToFrame;
        private int PlanetaryHeadRingFrameUpdater;
        private int PlanetaryHeadRingFrameCounter = 0;
        private int PlanetaryHeadWaterTickToFrame;
        private int PlanetaryHeadWaterFrameUpdater;
        private int PlanetaryHeadWaterFrameCounter = 0;

        public bool KnightwalkerBodyEquipped; //corresponding equip bool
        private int KnightwalkerCapeFrameCounter;
        private int KnightwalkerCapeFrameUpdater;
        private int KnightwalkerCapeTickToFrame;
        private int KnightwalkerFlameFrameCounter;
        private int KnightwalkerFlameFrameUpdater;
        private int KnightwalkerFlameTickToFrame;

        public bool KnightwalkerAlt;

        public bool KnightwalkerHeadEquipped;
        private int KnightwalkerHeadFrameCounter;
        private int KnightwalkerHeadFrameUpdater;
        private int KnightwalkerHeadTickToFrame;

<<<<<<< HEAD
        public bool NineTailedFoxAccEquipped;
        private int NineTailedFoxFrameCounter;
        public int NineTailedFoxFrameIndex;
        private int NineTailedFoxTickCounter;
=======
        public bool StarlightBodyEquipped; // Corresponding equip bool

        private int walkUpShift; //-2 when the walk cycle has 'up' frames

        // Starting Items
        public override IEnumerable<Item> AddStartingItems(bool mediumcoreDeath)
        {
            return new[] {
                new Item(ModContent.ItemType<TravellerHead>()),
                new Item(ModContent.ItemType<TravellerBody>()),
                new Item(ModContent.ItemType<TravellerLegs>())
            };

        }
>>>>>>> de52f131032681c579f6e408edf54738d2c2b681

        public bool StarlightBodyEquipped;

        public override void PreUpdate()
        {
            if (Player.velocity == Vector2.Zero)
                isIdle = true;
            else
                isIdle = false;

            //0,frameNum * frame hei, width, height
            var pl = Player.bodyFrame.Y / 56;
            if (pl == 5)
                isJumping = true;
            if (pl == 7 || pl == 8 || pl == 9 || pl == 14 || pl == 15 || pl == 16)
                walkUpShift = -2;
            else
                walkUpShift = 0;


            if (NineTailedFoxAccEquipped)
            {
                NineTailedFoxTickCounter++;
                if (NineTailedFoxTickCounter == 8) //every 8 ticks update
                {
                    NineTailedFoxTickCounter = 0;
                    NineTailedFoxFrameCounter++; //next frame
                    if (NineTailedFoxFrameCounter >= 10) //loop all frames from 0 to 9
                        NineTailedFoxFrameCounter = 0; //reset to first frame
                }

                NineTailedFoxFrameIndex = isJumping ? 10 : NineTailedFoxFrameCounter;
            }

            // todo might still be needed with new drawlayers
            
            //     if (StarlightBodyEquipped) _playerFrame = player.bodyFrame; //grabs player rect
            //
            //     if (KnightwalkerBodyEquipped)
            //     {
            //         if (player.grapCount > 0 && !isIdle) //when grappling and not not moving (grappled still)
            //             //0,frameNum * frame hei, width, height 
            //             _playerFrame = new Rectangle(0, 6 * (1120 / 20), 40, 1120 / 20);
            //         else
            //             _playerFrame = player.bodyFrame; //grabs player rect
            //     }
            //
            //
            //     if (KnightwalkerBodyEquipped)
            //     {
            //         KnightwalkerFlameTickToFrame++;
            //         if (KnightwalkerFlameTickToFrame == 5) //every 5 ticks update
            //         {
            //             KnightwalkerFlameFrameCounter++; //next frame
            //             if (KnightwalkerFlameFrameCounter >= 8) //loop all frames from 0 to 7
            //                 KnightwalkerFlameFrameCounter = 0; //reset to first frame
            //             KnightwalkerFlameTickToFrame = 0; //reset tick counter
            //         }
            //
            //         if (isIdle)
            //         {
            //             KnightwalkerCapeTickToFrame++;
            //             if (KnightwalkerCapeTickToFrame == 8) //every 8 ticks update
            //             {
            //                 KnightwalkerCapeFrameCounter++; //next frame
            //                 if (KnightwalkerCapeFrameCounter >= 20) //loop all frames from 0 to 20
            //                     KnightwalkerCapeFrameCounter = 0; //reset to first frame
            //                 KnightwalkerCapeTickToFrame = 0; //reset tick counter
            //             }
            //         }
            //         else
            //         {
            //             KnightwalkerCapeFrameCounter = 21; //set to empty frame when moving
            //         }
            //     }
            //
            //     KnightwalkerFlameFrameUpdater = KnightwalkerFlameFrameCounter;
            //     KnightwalkerCapeFrameUpdater = KnightwalkerCapeFrameCounter;
            //
            //
            //     if (KnightwalkerHeadEquipped)
            //     {
            //         KnightwalkerHeadTickToFrame++;
            //         if (KnightwalkerHeadTickToFrame == 5) //every 5 ticks update
            //         {
            //             KnightwalkerHeadFrameCounter++; //next frame
            //             if (KnightwalkerHeadFrameCounter >= 8) //loop all frames from 0 to 7
            //                 KnightwalkerHeadFrameCounter = 0; //reset to first frame
            //             KnightwalkerHeadTickToFrame = 0; //reset tick counter
            //         }
            //     }
            //
            //     KnightwalkerHeadFrameUpdater = KnightwalkerHeadFrameCounter;
            //
            //
            //     if (BubbleheadHeadEquipped)
            //     {
            //         BubbleheadHeadTickToFrame++;
            //         if (BubbleheadHeadTickToFrame == 5) //every 5 ticks update
            //         {
            //             BubbleheadHeadFrameCounter++; //next frame
            //             if (BubbleheadHeadFrameCounter >= 14) //loop all frames from 0 to 7
            //                 BubbleheadHeadFrameCounter = 0; //reset to first frame
            //             BubbleheadHeadTickToFrame = 0; //reset tick counter
            //         }
            //     }
            //
            //     BubbleheadHeadFrameUpdater = BubbleheadHeadFrameCounter;
            //
            //


            //
            //     //Planetary Head
            //     if (PlanetaryHeadEquipped)
            //     {
            //         //Water (Idle)
            //         if (isIdle || isJumping || player.grapCount > 0)
            //         {
            //             PlanetaryHeadWaterTickToFrame++;
            //             if (PlanetaryHeadWaterTickToFrame == 8) //every 5 ticks update
            //             {
            //                 PlanetaryHeadWaterFrameCounter++; //next frame
            //                 if (PlanetaryHeadWaterFrameCounter >= 4) //loop all frames from 0 to 3
            //                 {
            //                     PlanetaryHeadWaterFrameCounter = 0; //reset to first frame
            //                 }
            //
            //                 PlanetaryHeadWaterTickToFrame = 0; //reset tick counter
            //             }
            //         }
            //         else
            //         {
            //             PlanetaryHeadWaterFrameCounter = 5; //set to empty frame if not idle
            //         }
            //
            //         //Ring (Always)
            //         PlanetaryHeadRingTickToFrame++;
            //         if (PlanetaryHeadRingTickToFrame == 10) //every 5 ticks update
            //         {
            //             PlanetaryHeadRingFrameCounter++; //next frame
            //             if (PlanetaryHeadRingFrameCounter >= 4) //loop all frames from 0 to 3
            //             {
            //                 PlanetaryHeadRingFrameCounter = 0; //reset to first frame
            //             }
            //
            //             PlanetaryHeadRingTickToFrame = 0; //reset tick counter
            //         }
            //     }
            //
            //     PlanetaryHeadWaterFrameUpdater = PlanetaryHeadWaterFrameCounter;
            //     PlanetaryHeadRingFrameUpdater = PlanetaryHeadRingFrameCounter;
        }

        public override void ResetEffects() //reset all the equip type booleans
        {
            isIdle = false;
            isJumping = false;
            NineTailedFoxAccEquipped = false;
            StarlightBodyEquipped = false;
            KnightwalkerBodyEquipped = false;
            KnightwalkerHeadEquipped = false;
            BubbleheadHeadEquipped = false;
            PlanetaryHeadEquipped = false;
        }


        // public override void ModifyDrawLayers(List<PlayerLayer> layers)
        // {
        //     var legsIndex = layers.IndexOf(PlayerLayer.Skin);
        //     var headIndex = layers.IndexOf(PlayerLayer.Head);
        //     int armsIndex = layers.IndexOf(PlayerLayer.Arms);
        //     if (StarlightBodyEquipped)
        //     {
        //         layers.Insert(legsIndex - 1, StarlightDreamScarfGlow);
        //         layers.Insert(legsIndex - 1, StarlightDreamScarf);
        //     }
        //
        //     if (KnightwalkerHeadEquipped) layers.Insert(legsIndex - 1, KnightwalkerHeadAddons);
        //
        //     if (KnightwalkerBodyEquipped) layers.Insert(legsIndex - 1, KnightwalkerBodyAddons);
        //
        //     if (BubbleheadHeadEquipped) layers.Insert(headIndex + 1, BubbleheadHeadAddons);
        //
        //     if (PlanetaryHeadEquipped)
        //     {
        //         layers.Insert(armsIndex + 1, PlanetaryHeadAddonsFront);
        //         layers.Insert(headIndex + 1, PlanetaryHeadAddons);
        //     }
        //
        //     if (FoxTailsEquipped) layers.Insert(legsIndex - 1, NineTailedFoxTail);
        //
        //     var headLayer = layers.FindIndex(l => l == PlayerLayer.Head);
        //     var bodyLayer = layers.FindIndex(l => l == PlayerLayer.Body);
        //     var legsLayer = layers.FindIndex(l => l == PlayerLayer.Legs);
        //     if (headLayer > -1)
        //     {
        //         layers.Insert(headLayer + 1, ContainmentSuitHeadGlowmask);
        //         layers.Insert(headLayer + 1, CyberAngelHeadGlowmask);
        //         layers.Insert(headLayer + 1, MushroomHeadGlowmask);
        //         layers.Insert(headLayer + 1, NexusHeadGlowmask);
        //         layers.Insert(headLayer + 1, KnighwalkerHeadGlowmask);
        //         layers.Insert(headLayer + 1, DeepDiverHeadGlowmask);
        //         layers.Insert(headLayer + 1, BountyHeadGlowmask);
        //         layers.Insert(headLayer + 1, StarlightDreamHeadGlowmask);
        //         layers.Insert(headLayer + 1, WitchsVoidHeadGlowmask);
        //         layers.Insert(headLayer + 1, CosmicTerrorHeadGlowmask);
        //         layers.Insert(headLayer + 1, ShadowSpellHeadGlowmask);
        //     }
        //
        //     if (bodyLayer > -1)
        //     {
        //         layers.Insert(bodyLayer + 1, ContainmentSuitBodyGlowmask);
        //         layers.Insert(bodyLayer + 1, CyberAngelBodyGlowmask);
        //         layers.Insert(bodyLayer + 1, MushroomBodyGlowmask);
        //         layers.Insert(bodyLayer + 1, NexusBodyGlowmask);
        //         layers.Insert(bodyLayer + 1, NightlightBodyGlowmask);
        //         layers.Insert(bodyLayer + 1, CosmicTerrorBodyGlowmask);
        //         var armsLayer = layers.FindIndex(l => l == PlayerLayer.Arms);
        //         if (armsLayer > -1)
        //         {
        //             layers.Insert(armsLayer + 1, MushroomArmsGlowmask);
        //             layers.Insert(armsLayer + 1, NexusArmsGlowmask);
        //             layers.Insert(armsLayer + 1, CosmicTerrorArmsGlowmask);
        //         }
        //     }
        //
        //     if (legsLayer > -1)
        //     {
        //         layers.Insert(legsLayer + 1, CyberAngelLegsGlowmask);
        //         layers.Insert(legsLayer + 1, MushroomLegsGlowmask);
        //         layers.Insert(legsLayer + 1, NexusLegsGlowmask);
        //     }
        // }
    }
}

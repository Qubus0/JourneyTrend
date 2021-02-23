using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using JourneyTrend.Items.Vanity.Traveller;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace JourneyTrend
{
    [SuppressMessage("ReSharper", "UseObjectOrCollectionInitializer")]
    public class JourneyPlayer : ModPlayer
    {
        // Accessory type capes (not idle animated)
        private static Rectangle playerframe; //grabs playerframe for all below

        public static readonly PlayerLayer NineTailedFoxTail = new PlayerLayer("JourneyTrend", "NineTailedFoxTail",
            PlayerLayer.WaistAcc, delegate(PlayerDrawInfo drawInfo)
            {
                if (!drawInfo.drawPlayer.dead)
                {
                    var drawPlayer = drawInfo.drawPlayer;
                    var mod = ModLoader.GetMod("JourneyTrend");
                    var modPlayer = drawPlayer.GetModPlayer<JourneyPlayer>();
                    if (modPlayer.FoxTailsEquipped)
                    {
                        Rectangle? rectangle =
                            new Rectangle(0, modPlayer.NineTailedFrameUpdater * 56, 46, 56); //frame updater
                        var newColor = Lighting.GetColor((int) ((drawInfo.position.X + drawPlayer.width / 2f) / 16f),
                            (int) ((drawInfo.position.Y + drawPlayer.height / 2f) / 16f));
                        newColor = new Color(newColor.R, newColor.B, newColor.G, (int) ((1 - drawPlayer.shadow) * 255));
                        var texture = mod.GetTexture("Items/Vanity/NineTailedFox/NineTailedFoxAcc_Tails");
                        var num = texture.Height / 11;
                        var num2 = (int) (drawInfo.position.X + drawPlayer.width / 2f - Main.screenPosition.X -
                                          3 * drawPlayer.direction); //has offset of -3 px
                        var num3 = (int) (drawInfo.position.Y + drawPlayer.height / 2f - Main.screenPosition.Y - 3f +
                                          modPlayer.walkUpShift);
                        var item = new DrawData(texture, new Vector2(num2, num3), rectangle,
                            newColor, 0f, new Vector2(texture.Width / 2f, num / 2f), 1f, drawInfo.spriteEffects, 0)
                        {
                            shader = drawPlayer.cWings //wing acc -> wing shader (c...)
                        };
                        Main.playerDrawData.Add(item);
                    }
                }
            });

        public static readonly PlayerLayer StarlightDreamScarf = new PlayerLayer("JourneyTrend", "StarlightDreamScarf",
            PlayerLayer.BackAcc, delegate(PlayerDrawInfo drawInfo)
            {
                //name here same as name								here.	Needs correct accessory here as well
                if (!drawInfo.drawPlayer.dead)
                {
                    var drawPlayer = drawInfo.drawPlayer;
                    var mod = ModLoader.GetMod("JourneyTrend");
                    var modPlayer = drawPlayer.GetModPlayer<JourneyPlayer>();
                    if (modPlayer.StarlightBodyEquipped) //needs corect equip bool
                    {
                        Rectangle? rectangle = playerframe; //updates rect here
                        var newColor = Lighting.GetColor((int) ((drawInfo.position.X + drawPlayer.width / 2f) / 16f),
                            (int) ((drawInfo.position.Y + drawPlayer.height / 2f) / 16f));
                        newColor = new Color(newColor.R, newColor.B, newColor.G, (int) ((1 - drawPlayer.shadow) * 255));
                        var texture =
                            mod.GetTexture(
                                "Items/Vanity/StarlightDream/StarlightDreamAcc_Back"); //needs correct sprite path
                        var num = texture.Height / 20; //20 -> number of frames
                        var num2 = (int) (drawInfo.position.X + drawPlayer.width / 2f -
                                          Main.screenPosition.X); //no offset from player rect
                        var num3 = (int) (drawInfo.position.Y + drawPlayer.height / 2f - Main.screenPosition.Y - 3f +
                                          modPlayer.walkUpShift);
                        var item = new DrawData(texture, new Vector2(num2, num3), rectangle,
                            newColor, 0f, new Vector2(texture.Width / 2f, num / 2f), 1f, drawInfo.spriteEffects, 0)
                        {
                            shader = drawPlayer.cBody //part of body -> body shader (c...)
                        };
                        Main.playerDrawData.Add(item);
                    }
                }
            }); //don't forget to change ModifyDrawlayers at the bottom

        public static readonly PlayerLayer StarlightDreamScarfGlow = new PlayerLayer("JourneyTrend",
            "StarlightDreamScarfGlow", PlayerLayer.BackAcc, delegate(PlayerDrawInfo drawInfo)
            {
                //name here same as name								here.	Needs correct accessory here as well
                if (!drawInfo.drawPlayer.dead)
                {
                    var drawPlayer = drawInfo.drawPlayer;
                    var mod = ModLoader.GetMod("JourneyTrend");
                    var modPlayer = drawPlayer.GetModPlayer<JourneyPlayer>();
                    if (modPlayer.StarlightBodyEquipped) //needs corect equip bool
                    {
                        Rectangle? rectangle = playerframe; //updates rect here
                        var newColor = Color.White;
                        var texture =
                            mod.GetTexture(
                                "Items/Vanity/StarlightDream/StarlightDreamAcc_Glow"); //needs correct sprite path
                        var num = texture.Height / 20; //20 -> number of frames
                        var num2 = (int) (drawInfo.position.X + drawPlayer.width / 2f -
                                          Main.screenPosition.X); //no offset from player rect
                        var num3 = (int) (drawInfo.position.Y + drawPlayer.height / 2f - Main.screenPosition.Y - 3f +
                                          modPlayer.walkUpShift);
                        var item = new DrawData(texture, new Vector2(num2, num3), rectangle,
                            newColor, 0f, new Vector2(texture.Width / 2f, num / 2f), 1f, drawInfo.spriteEffects, 0)
                        {
                            shader = drawPlayer.cBody //part of body -> body shader (c...)
                        };
                        Main.playerDrawData.Add(item);
                    }
                }
            }); //don't forget to change ModifyDrawlayers at the bottom

        public static readonly PlayerLayer KnightwalkerHeadAddons = new PlayerLayer("JourneyTrend",
            "KnightwalkerHeadAddons", PlayerLayer.Head, delegate(PlayerDrawInfo drawInfo)
            {
                if (!drawInfo.drawPlayer.dead)
                {
                    var drawPlayer = drawInfo.drawPlayer;
                    var mod = ModLoader.GetMod("JourneyTrend");
                    var modPlayer = drawPlayer.GetModPlayer<JourneyPlayer>();
                    if (modPlayer.KnightwalkerHeadEquipped)
                    {
                        var texture =
                            mod.GetTexture(
                                "Items/Vanity/Knightwalker/KnightwalkerHeadflame_Idle"); //needs correct sprite path
                        var num = texture.Height / 8; //8 -> number of frames
                        Rectangle? rectangle = new Rectangle(0, modPlayer.KnightwalkerHeadFrameUpdater * num,
                            texture.Width, num); //frame updater
                        var color = Color.White;
                        var num2 = (int) (drawInfo.position.X + drawPlayer.width / 2f - Main.screenPosition.X +
                                          drawPlayer.direction);
                        var num3 = (int) (drawInfo.position.Y + drawPlayer.height / 2f - Main.screenPosition.Y - 27f +
                                          modPlayer.walkUpShift);
                        var item = new DrawData(texture, new Vector2(num2, num3), rectangle,
                            color, 0f, new Vector2(texture.Width / 2f, num / 2f), 1f, drawInfo.spriteEffects, 0)
                        {
                            shader = drawPlayer.cHead //use correct shader (c...)
                        };
                        Main.playerDrawData.Add(item);
                    }
                }
            });

        public static readonly PlayerLayer KnightwalkerBodyAddons = new PlayerLayer("JourneyTrend",
            "KnightwalkerBodyAddons", PlayerLayer.BackAcc, delegate(PlayerDrawInfo drawInfo)
            {
                //name here same as name								here.	Needs correct accessory here as well
                if (!drawInfo.drawPlayer.dead)
                {
                    var drawPlayer = drawInfo.drawPlayer;
                    var mod = ModLoader.GetMod("JourneyTrend");
                    var modPlayer = drawPlayer.GetModPlayer<JourneyPlayer>();
                    if (modPlayer.KnightwalkerBodyEquipped) //needs corect equip bool
                    {
                        var texture =
                            mod.GetTexture(
                                "Items/Vanity/Knightwalker/KnightwalkerCape_Idle"); //needs correct sprite path
                        var num = texture.Height / 21; //21 -> number of frames
                        Rectangle? rectangle = new Rectangle(0, modPlayer.KnightwalkerCapeFrameUpdater * num,
                            texture.Width, num); //frame updater
                        var color = Lighting.GetColor((int) ((drawInfo.position.X + drawPlayer.width / 2f) / 16f),
                            (int) ((drawInfo.position.Y + drawPlayer.height / 2f) / 16f));
                        color = new Color(color.R, color.B, color.G, (int) ((1 - drawPlayer.shadow) * 255));
                        var num2 = (int) (drawInfo.position.X + drawPlayer.width / 2f - Main.screenPosition.X -
                                          6 * drawPlayer.direction);
                        var num3 = (int) (drawInfo.position.Y + drawPlayer.height / 2f - Main.screenPosition.Y + 7f +
                                          modPlayer.walkUpShift);
                        var item = new DrawData(texture, new Vector2(num2, num3), rectangle,
                            color, 0f, new Vector2(texture.Width / 2f, num / 2f), 1f, drawInfo.spriteEffects, 0)
                        {
                            shader = drawPlayer.cBody //use correct shader (c...)
                        };
                        Main.playerDrawData.Add(item);
                    }

                    if (modPlayer.KnightwalkerBodyEquipped) //needs corect equip bool
                    {
                        Rectangle? rectangle = playerframe; //updates rect here
                        var color = Lighting.GetColor(
                            (int) ((drawInfo.position.X + drawPlayer.width / 2f) / 16f), // ) replace these 3 lines
                            (int) ((drawInfo.position.Y + drawPlayer.height / 2f) /
                                   16f)); // ) with Color color = Color.White;
                        color = new Color(color.R, color.B, color.G,
                            (int) ((1 - drawPlayer.shadow) * 255)); // ) for glowmask
                        var texture =
                            mod.GetTexture(
                                "Items/Vanity/Knightwalker/KnightwalkerBodyAcc_Back"); //needs correct sprite path
                        var num = texture.Height / 20; //20 -> number of frames
                        var num2 = (int) (drawInfo.position.X + drawPlayer.width / 2f -
                                          Main.screenPosition.X); //no offset from player rect
                        var num3 = (int) (drawInfo.position.Y + drawPlayer.height / 2f - Main.screenPosition.Y - 3f +
                                          modPlayer.walkUpShift);
                        var item = new DrawData(texture, new Vector2(num2, num3), rectangle,
                            color, 0f, new Vector2(texture.Width / 2f, num / 2f), 1f, drawInfo.spriteEffects, 0)
                        {
                            shader = drawPlayer.cBody //use correct shader (c...)
                        };
                        Main.playerDrawData.Add(item);
                    }

                    if (modPlayer.KnightwalkerBodyEquipped) //needs corect equip bool
                    {
                        Texture2D texture;
                        if (!modPlayer.KnightwalkerAlt)
                            texture = mod.GetTexture(
                                "Items/Vanity/Knightwalker/KnightwalkerBodyflame_Idle"); //needs correct sprite path
                        else
                            texture = mod.GetTexture("Items/Vanity/Knightwalker/KnightwalkerBodyflame_Idle1");
                        var num = texture.Height / 8; //8 -> number of frames
                        Rectangle? rectangle = new Rectangle(0, modPlayer.KnightwalkerFlameFrameUpdater * num,
                            texture.Width, num); //frame updater
                        var color = Color.White;
                        var num2 = (int) (drawInfo.position.X + drawPlayer.width / 2f - Main.screenPosition.X -
                                          2 * drawPlayer.direction);
                        var num3 = (int) (drawInfo.position.Y + drawPlayer.height / 2f - Main.screenPosition.Y - 14f +
                                          modPlayer.walkUpShift);
                        var item = new DrawData(texture, new Vector2(num2, num3), rectangle,
                            color, 0f, new Vector2(texture.Width / 2f, num / 2f), 1f, drawInfo.spriteEffects, 0)
                        {
                            shader = drawPlayer.cBody //use correct shader (c...)
                        };
                        Main.playerDrawData.Add(item);
                    }
                }
            }); //don't forget to change ModifyDrawlayers at the bottom

        public static readonly PlayerLayer BubbleheadHeadAddons = new PlayerLayer("JourneyTrend",
            "BubbleheadHeadAddons", PlayerLayer.Head, delegate(PlayerDrawInfo drawInfo)
            {
                if (!drawInfo.drawPlayer.dead)
                {
                    var drawPlayer = drawInfo.drawPlayer;
                    var mod = ModLoader.GetMod("JourneyTrend");
                    var modPlayer = drawPlayer.GetModPlayer<JourneyPlayer>();
                    if (modPlayer.BubbleheadHeadEquipped)
                    {
                        var texture =
                            mod.GetTexture("Items/Vanity/Bubblehead/BubbleheadHead_Idle"); //needs correct sprite path
                        var num = texture.Height / 14; //14 -> number of frames
                        Rectangle? rectangle = new Rectangle(0, modPlayer.BubbleheadHeadFrameUpdater * num,
                            texture.Width, num); //frame updater
                        var color = Lighting.GetColor(
                            (int) ((drawInfo.position.X + drawPlayer.width / 2f) / 16f), // ) replace these 3 lines
                            (int) ((drawInfo.position.Y + drawPlayer.height / 2f) /
                                   16f)); // ) with Color color = Color.White;
                        color = new Color(color.R, color.B, color.G,
                            (int) ((1 - drawPlayer.shadow) * 255)); // ) for glowmask
                        var num2 = (int) (drawInfo.position.X + drawPlayer.width / 2f - Main.screenPosition.X +
                                          drawPlayer.direction);
                        var num3 = (int) (drawInfo.position.Y + drawPlayer.height / 2f - Main.screenPosition.Y - 14f +
                                          modPlayer.walkUpShift);
                        var item = new DrawData(texture, new Vector2(num2, num3), rectangle,
                            color, 0f, new Vector2(texture.Width / 2f, num / 2f), 1f, drawInfo.spriteEffects, 0)
                        {
                            shader = drawPlayer.cHead //use correct shader (c...)
                        };
                        Main.playerDrawData.Add(item);
                    }
                }
            }); //don't forget to change ModifyDrawlayers at the bottom

        //Glowmask business
        public static readonly PlayerLayer ContainmentSuitHeadGlowmask = new PlayerLayer("JourneyTrend",
            "ContainmentSuitHeadGlowmask", PlayerLayer.Head, delegate(PlayerDrawInfo drawInfo)
            {
                if (drawInfo.shadow != 0f || drawInfo.drawPlayer.dead) return;
                var drawPlayer = drawInfo.drawPlayer;
                var mod = ModLoader.GetMod("JourneyTrend");
                if (drawPlayer.head != mod.GetEquipSlot("ContainmentSuitHead", EquipType.Head)) return;
                var texture = mod.GetTexture("Items/Vanity/ContainmentSuit/ContainmentSuitHead_Glowmask");
                float drawX = (int) drawInfo.position.X + drawPlayer.width / 2;
                var drawY = (int) drawInfo.position.Y + drawPlayer.height - drawPlayer.headFrame.Height / 2 + 4f - 34f;
                var origin = drawInfo.headOrigin;
                var position = new Vector2(drawX, drawY) + drawPlayer.headPosition - Main.screenPosition;
                var alpha = (255 - drawPlayer.immuneAlpha) / 255f;
                var color = Color.White;
                var frame = new Rectangle(0, drawPlayer.bodyFrame.Y, texture.Width, texture.Height / 20);
                var rotation = drawPlayer.headRotation;
                var spriteEffects = drawInfo.spriteEffects;
                var drawData = new DrawData(texture, position, frame, color * alpha, rotation, origin, 1f,
                    spriteEffects, 0);
                drawData.shader = drawInfo.headArmorShader;
                Main.playerDrawData.Add(drawData);
            });

        public static readonly PlayerLayer ContainmentSuitBodyGlowmask = new PlayerLayer("JourneyTrend",
            "ContainmentSuitBodyGlowmask", PlayerLayer.Body, delegate(PlayerDrawInfo drawInfo)
            {
                if (drawInfo.shadow != 0f || drawInfo.drawPlayer.dead) return;
                var drawPlayer = drawInfo.drawPlayer;
                var mod = ModLoader.GetMod("JourneyTrend");
                if (drawPlayer.body != mod.GetEquipSlot("ContainmentSuitBody", EquipType.Body)) return;
                var texture = mod.GetTexture("Items/Vanity/ContainmentSuit/ContainmentSuitBody_Glowmask");
                float drawX = (int) drawInfo.position.X + drawPlayer.width / 2;
                var drawY = (int) drawInfo.position.Y + drawPlayer.height - drawPlayer.bodyFrame.Height / 2 + 4f;
                var origin = drawInfo.bodyOrigin;
                var position = new Vector2(drawX, drawY) + drawPlayer.bodyPosition - Main.screenPosition;
                var alpha = (255 - drawPlayer.immuneAlpha) / 255f;
                var color = Color.White;
                var frame = drawPlayer.bodyFrame;
                var rotation = drawPlayer.bodyRotation;
                var spriteEffects = drawInfo.spriteEffects;
                var drawData = new DrawData(texture, position, frame, color * alpha, rotation, origin, 1f,
                    spriteEffects, 0);
                drawData.shader = drawInfo.bodyArmorShader;
                Main.playerDrawData.Add(drawData);
            });

        public static readonly PlayerLayer CyberAngelHeadGlowmask = new PlayerLayer("JourneyTrend",
            "CyberAngelHeadGlowmask", PlayerLayer.Head, delegate(PlayerDrawInfo drawInfo)
            {
                if (drawInfo.shadow != 0f || drawInfo.drawPlayer.dead) return;
                var drawPlayer = drawInfo.drawPlayer;
                var mod = ModLoader.GetMod("JourneyTrend");
                if (drawPlayer.head != mod.GetEquipSlot("CyberAngelHead", EquipType.Head) &&
                    drawPlayer.head != mod.GetEquipSlot("CyberAngelHead1", EquipType.Head)) return;
                var texture = mod.GetTexture("Items/Vanity/CyberAngel/CyberAngelHead_Glow");
                float drawX = (int) drawInfo.position.X + drawPlayer.width / 2;
                var drawY = (int) drawInfo.position.Y + drawPlayer.height - drawPlayer.headFrame.Height / 2 + 4f - 34f;
                var origin = drawInfo.headOrigin;
                var position = new Vector2(drawX, drawY) + drawPlayer.headPosition - Main.screenPosition;
                var alpha = (255 - drawPlayer.immuneAlpha) / 255f;
                var color = Color.White;
                var frame = new Rectangle(0, drawPlayer.bodyFrame.Y, texture.Width, texture.Height / 20);
                var rotation = drawPlayer.headRotation;
                var spriteEffects = drawInfo.spriteEffects;
                var drawData = new DrawData(texture, position, frame, color * alpha, rotation, origin, 1f,
                    spriteEffects, 0);
                drawData.shader = drawInfo.headArmorShader;
                Main.playerDrawData.Add(drawData);
            });

        public static readonly PlayerLayer CyberAngelBodyGlowmask = new PlayerLayer("JourneyTrend",
            "CyberAngelBodyGlowmask", PlayerLayer.Body, delegate(PlayerDrawInfo drawInfo)
            {
                if (drawInfo.shadow != 0f || drawInfo.drawPlayer.dead) return;
                var drawPlayer = drawInfo.drawPlayer;
                var mod = ModLoader.GetMod("JourneyTrend");
                if (drawPlayer.body != mod.GetEquipSlot("CyberAngelBody", EquipType.Body)) return;
                var texture = mod.GetTexture("Items/Vanity/CyberAngel/CyberAngelBody_Glow");
                float drawX = (int) drawInfo.position.X + drawPlayer.width / 2;
                var drawY = (int) drawInfo.position.Y + drawPlayer.height - drawPlayer.bodyFrame.Height / 2 + 4f;
                var origin = drawInfo.bodyOrigin;
                var position = new Vector2(drawX, drawY) + drawPlayer.bodyPosition - Main.screenPosition;
                var alpha = (255 - drawPlayer.immuneAlpha) / 255f;
                var color = Color.White;
                var frame = drawPlayer.bodyFrame;
                var rotation = drawPlayer.bodyRotation;
                var spriteEffects = drawInfo.spriteEffects;
                var drawData = new DrawData(texture, position, frame, color * alpha, rotation, origin, 1f,
                    spriteEffects, 0);
                drawData.shader = drawInfo.bodyArmorShader;
                Main.playerDrawData.Add(drawData);
            });

        public static readonly PlayerLayer CyberAngelLegsGlowmask = new PlayerLayer("JourneyTrend",
            "CyberAngelLegsGlowmask", PlayerLayer.Legs, delegate(PlayerDrawInfo drawInfo)
            {
                if (drawInfo.shadow != 0f || drawInfo.drawPlayer.dead) return;
                var drawPlayer = drawInfo.drawPlayer;
                var mod = ModLoader.GetMod("JourneyTrend");
                if (drawPlayer.legs != mod.GetEquipSlot("CyberAngelLegs", EquipType.Legs)) return;
                var texture = mod.GetTexture("Items/Vanity/CyberAngel/CyberAngelLegs_Glow");
                float drawX = (int) drawInfo.position.X + drawPlayer.width / 2;
                var drawY = (int) drawInfo.position.Y + drawPlayer.height - drawPlayer.legFrame.Height / 2 + 4f + 14f;
                var origin = drawInfo.legOrigin;
                var position = new Vector2(drawX, drawY) + drawPlayer.legPosition - Main.screenPosition;
                var alpha = (255 - drawPlayer.immuneAlpha) / 255f;
                var color = new Color(255 * 100 / 100, 255 * 100 / 100, 255 * 100 / 100);
                var frame = drawPlayer.legFrame;
                var rotation = drawPlayer.legRotation;
                var spriteEffects = drawInfo.spriteEffects;
                var drawData = new DrawData(texture, position, frame, color * alpha, rotation, origin, 1f,
                    spriteEffects, 0);
                drawData.shader = drawInfo.legArmorShader;
                Main.playerDrawData.Add(drawData);
            });

        public static readonly PlayerLayer MushroomHeadGlowmask = new PlayerLayer("JourneyTrend",
            "MushroomHeadGlowmask", PlayerLayer.Head, delegate(PlayerDrawInfo drawInfo)
            {
                if (drawInfo.shadow != 0f || drawInfo.drawPlayer.dead) return;
                var drawPlayer = drawInfo.drawPlayer;
                var mod = ModLoader.GetMod("JourneyTrend");
                if (drawPlayer.head != mod.GetEquipSlot("MushroomAlchemistHead", EquipType.Head)) return;
                var texture = mod.GetTexture("Items/Vanity/MushroomAlchemist/MushroomAlchemistHead_Glow");
                float drawX = (int) drawInfo.position.X + drawPlayer.width / 2;
                var drawY = (int) drawInfo.position.Y + drawPlayer.height - drawPlayer.headFrame.Height / 2 + 4f - 34f;
                var origin = drawInfo.headOrigin;
                var position = new Vector2(drawX, drawY) + drawPlayer.headPosition - Main.screenPosition;
                var alpha = (255 - drawPlayer.immuneAlpha) / 255f;
                var color = Color.White;
                var frame = new Rectangle(0, drawPlayer.bodyFrame.Y, texture.Width, texture.Height / 20);
                var rotation = drawPlayer.headRotation;
                var spriteEffects = drawInfo.spriteEffects;
                var drawData = new DrawData(texture, position, frame, color * alpha, rotation, origin, 1f,
                    spriteEffects, 0);
                drawData.shader = drawInfo.headArmorShader;
                Main.playerDrawData.Add(drawData);
            });

        public static readonly PlayerLayer MushroomBodyGlowmask = new PlayerLayer("JourneyTrend",
            "MushroomBodyGlowmask", PlayerLayer.Body, delegate(PlayerDrawInfo drawInfo)
            {
                if (drawInfo.shadow != 0f || drawInfo.drawPlayer.dead) return;
                var drawPlayer = drawInfo.drawPlayer;
                var mod = ModLoader.GetMod("JourneyTrend");
                if (drawPlayer.body != mod.GetEquipSlot("MushroomAlchemistBody", EquipType.Body)) return;
                var texture = mod.GetTexture("Items/Vanity/MushroomAlchemist/MushroomAlchemistBody_Glow");
                float drawX = (int) drawInfo.position.X + drawPlayer.width / 2;
                var drawY = (int) drawInfo.position.Y + drawPlayer.height - drawPlayer.bodyFrame.Height / 2 + 4f;
                var origin = drawInfo.bodyOrigin;
                var position = new Vector2(drawX, drawY) + drawPlayer.bodyPosition - Main.screenPosition;
                var alpha = (255 - drawPlayer.immuneAlpha) / 255f;
                var color = Color.White;
                var frame = drawPlayer.bodyFrame;
                var rotation = drawPlayer.bodyRotation;
                var spriteEffects = drawInfo.spriteEffects;
                var drawData = new DrawData(texture, position, frame, color * alpha, rotation, origin, 1f,
                    spriteEffects, 0);
                drawData.shader = drawInfo.bodyArmorShader;
                Main.playerDrawData.Add(drawData);
            });

        public static readonly PlayerLayer MushroomLegsGlowmask = new PlayerLayer("JourneyTrend",
            "MushroomLegsGlowmask", PlayerLayer.Legs, delegate(PlayerDrawInfo drawInfo)
            {
                if (drawInfo.shadow != 0f || drawInfo.drawPlayer.dead) return;
                var drawPlayer = drawInfo.drawPlayer;
                var mod = ModLoader.GetMod("JourneyTrend");
                if (drawPlayer.legs != mod.GetEquipSlot("MushroomAlchemistLegs", EquipType.Legs)) return;
                var texture = mod.GetTexture("Items/Vanity/MushroomAlchemist/MushroomAlchemistLegs_Glow");
                float drawX = (int) drawInfo.position.X + drawPlayer.width / 2;
                var drawY = (int) drawInfo.position.Y + drawPlayer.height - drawPlayer.legFrame.Height / 2 + 4f + 14f;
                var origin = drawInfo.legOrigin;
                var position = new Vector2(drawX, drawY) + drawPlayer.legPosition - Main.screenPosition;
                var alpha = (255 - drawPlayer.immuneAlpha) / 255f;
                var color = new Color(255 * 100 / 100, 255 * 100 / 100, 255 * 100 / 100);
                var frame = drawPlayer.legFrame;
                var rotation = drawPlayer.legRotation;
                var spriteEffects = drawInfo.spriteEffects;
                var drawData = new DrawData(texture, position, frame, color * alpha, rotation, origin, 1f,
                    spriteEffects, 0);
                drawData.shader = drawInfo.legArmorShader;
                Main.playerDrawData.Add(drawData);
            });

        public static readonly PlayerLayer MushroomArmsGlowmask = new PlayerLayer("JourneyTrend",
            "MushroomArmsGlowmask", PlayerLayer.Arms, delegate(PlayerDrawInfo drawInfo)
            {
                if (drawInfo.shadow != 0f || drawInfo.drawPlayer.dead) return;
                var drawPlayer = drawInfo.drawPlayer;
                var mod = ModLoader.GetMod("JourneyTrend");
                if (drawPlayer.body != mod.GetEquipSlot("MushroomAlchemistBody", EquipType.Body)) return;
                var texture = mod.GetTexture("Items/Vanity/MushroomAlchemist/MushroomAlchemistBody_ArmsGlow");
                float drawX = (int) drawInfo.position.X + drawPlayer.width / 2;
                var drawY = (int) drawInfo.position.Y + drawPlayer.height - drawPlayer.bodyFrame.Height / 2 + 4f;
                var origin = drawInfo.bodyOrigin;
                var position = new Vector2(drawX, drawY) + drawPlayer.bodyPosition - Main.screenPosition;
                var alpha = (255 - drawPlayer.immuneAlpha) / 255f;
                var color = new Color(255 * 100 / 100, 255 * 100 / 100, 255 * 100 / 100);
                var frame = drawPlayer.bodyFrame;
                var rotation = drawPlayer.bodyRotation;
                var spriteEffects = drawInfo.spriteEffects;
                var drawData = new DrawData(texture, position, frame, color * alpha, rotation, origin, 1f,
                    spriteEffects, 0);
                drawData.shader = drawInfo.bodyArmorShader;
                Main.playerDrawData.Add(drawData);
            });

        public static readonly PlayerLayer NexusHeadGlowmask = new PlayerLayer("JourneyTrend", "NexusHeadGlowmask",
            PlayerLayer.Head, delegate(PlayerDrawInfo drawInfo)
            {
                if (drawInfo.shadow != 0f || drawInfo.drawPlayer.dead) return;
                var drawPlayer = drawInfo.drawPlayer;
                var mod = ModLoader.GetMod("JourneyTrend");
                if (drawPlayer.head != mod.GetEquipSlot("NexusHead", EquipType.Head)) return;
                var texture = mod.GetTexture("Items/Vanity/Nexus/NexusHead_Glow");
                float drawX = (int) drawInfo.position.X + drawPlayer.width / 2;
                var drawY = (int) drawInfo.position.Y + drawPlayer.height - drawPlayer.headFrame.Height / 2 + 4f - 34f;
                var origin = drawInfo.headOrigin;
                var position = new Vector2(drawX, drawY) + drawPlayer.headPosition - Main.screenPosition;
                var alpha = (255 - drawPlayer.immuneAlpha) / 255f;
                var color = Color.White;
                var frame = new Rectangle(0, drawPlayer.bodyFrame.Y, texture.Width, texture.Height / 20);
                var rotation = drawPlayer.headRotation;
                var spriteEffects = drawInfo.spriteEffects;
                var drawData = new DrawData(texture, position, frame, color * alpha, rotation, origin, 1f,
                    spriteEffects, 0);
                drawData.shader = drawInfo.headArmorShader;
                Main.playerDrawData.Add(drawData);
            });

        public static readonly PlayerLayer NexusBodyGlowmask = new PlayerLayer("JourneyTrend", "NexusBodyGlowmask",
            PlayerLayer.Body, delegate(PlayerDrawInfo drawInfo)
            {
                if (drawInfo.shadow != 0f || drawInfo.drawPlayer.dead) return;
                var drawPlayer = drawInfo.drawPlayer;
                var mod = ModLoader.GetMod("JourneyTrend");
                if (drawPlayer.body != mod.GetEquipSlot("NexusBody", EquipType.Body)) return;
                var texture = mod.GetTexture("Items/Vanity/Nexus/NexusBody_Glow");
                if (!drawPlayer.Male) texture = mod.GetTexture("Items/Vanity/Nexus/NexusBody_FemaleGlow");
                float drawX = (int) drawInfo.position.X + drawPlayer.width / 2;
                var drawY = (int) drawInfo.position.Y + drawPlayer.height - drawPlayer.bodyFrame.Height / 2 + 4f;
                var origin = drawInfo.bodyOrigin;
                var position = new Vector2(drawX, drawY) + drawPlayer.bodyPosition - Main.screenPosition;
                var alpha = (255 - drawPlayer.immuneAlpha) / 255f;
                var color = Color.White;
                var frame = drawPlayer.bodyFrame;
                var rotation = drawPlayer.bodyRotation;
                var spriteEffects = drawInfo.spriteEffects;
                var drawData = new DrawData(texture, position, frame, color * alpha, rotation, origin, 1f,
                    spriteEffects, 0);
                drawData.shader = drawInfo.bodyArmorShader;
                Main.playerDrawData.Add(drawData);
            });

        public static readonly PlayerLayer NexusLegsGlowmask = new PlayerLayer("JourneyTrend", "NexusLegsGlowmask",
            PlayerLayer.Legs, delegate(PlayerDrawInfo drawInfo)
            {
                if (drawInfo.shadow != 0f || drawInfo.drawPlayer.dead) return;
                var drawPlayer = drawInfo.drawPlayer;
                var mod = ModLoader.GetMod("JourneyTrend");
                if (drawPlayer.legs != mod.GetEquipSlot("NexusLegs", EquipType.Legs)) return;
                var texture = mod.GetTexture("Items/Vanity/Nexus/NexusLegs_Glow");
                float drawX = (int) drawInfo.position.X + drawPlayer.width / 2;
                var drawY = (int) drawInfo.position.Y + drawPlayer.height - drawPlayer.legFrame.Height / 2 + 4f + 14f;
                var origin = drawInfo.legOrigin;
                var position = new Vector2(drawX, drawY) + drawPlayer.legPosition - Main.screenPosition;
                var alpha = (255 - drawPlayer.immuneAlpha) / 255f;
                var color = Color.White;
                var frame = drawPlayer.legFrame;
                var rotation = drawPlayer.legRotation;
                var spriteEffects = drawInfo.spriteEffects;
                var drawData = new DrawData(texture, position, frame, color * alpha, rotation, origin, 1f,
                    spriteEffects, 0);
                drawData.shader = drawInfo.legArmorShader;
                Main.playerDrawData.Add(drawData);
            });

        public static readonly PlayerLayer NexusArmsGlowmask = new PlayerLayer("JourneyTrend", "NexusArmsGlowmask",
            PlayerLayer.Arms, delegate(PlayerDrawInfo drawInfo)
            {
                if (drawInfo.shadow != 0f || drawInfo.drawPlayer.dead) return;
                var drawPlayer = drawInfo.drawPlayer;
                var mod = ModLoader.GetMod("JourneyTrend");
                if (drawPlayer.body != mod.GetEquipSlot("NexusBody", EquipType.Body)) return;
                var texture = mod.GetTexture("Items/Vanity/Nexus/NexusBody_ArmsGlow");
                float drawX = (int) drawInfo.position.X + drawPlayer.width / 2;
                var drawY = (int) drawInfo.position.Y + drawPlayer.height - drawPlayer.bodyFrame.Height / 2 + 4f;
                var origin = drawInfo.bodyOrigin;
                var position = new Vector2(drawX, drawY) + drawPlayer.bodyPosition - Main.screenPosition;
                var alpha = (255 - drawPlayer.immuneAlpha) / 255f;
                var color = Color.White;
                var frame = drawPlayer.bodyFrame;
                var rotation = drawPlayer.bodyRotation;
                var spriteEffects = drawInfo.spriteEffects;
                var drawData = new DrawData(texture, position, frame, color * alpha, rotation, origin, 1f,
                    spriteEffects, 0);
                drawData.shader = drawInfo.bodyArmorShader;
                Main.playerDrawData.Add(drawData);
            });

        public static readonly PlayerLayer NightlightBodyGlowmask = new PlayerLayer("JourneyTrend",
            "NightlightBodyGlowmask", PlayerLayer.Body, delegate(PlayerDrawInfo drawInfo)
            {
                if (drawInfo.shadow != 0f || drawInfo.drawPlayer.dead) return;
                var drawPlayer = drawInfo.drawPlayer;
                var mod = ModLoader.GetMod("JourneyTrend");
                if (drawPlayer.body != mod.GetEquipSlot("NightlightBody", EquipType.Body)) return;
                var texture = mod.GetTexture("Items/Vanity/Nightlight/NightlightBody_Glow");
                float drawX = (int) drawInfo.position.X + drawPlayer.width / 2;
                var drawY = (int) drawInfo.position.Y + drawPlayer.height - drawPlayer.bodyFrame.Height / 2 + 4f;
                var origin = drawInfo.bodyOrigin;
                var position = new Vector2(drawX, drawY) + drawPlayer.bodyPosition - Main.screenPosition;
                var alpha = (255 - drawPlayer.immuneAlpha) / 255f;
                var color = Color.White;
                var frame = drawPlayer.bodyFrame;
                var rotation = drawPlayer.bodyRotation;
                var spriteEffects = drawInfo.spriteEffects;
                var drawData = new DrawData(texture, position, frame, color * alpha, rotation, origin, 1f,
                    spriteEffects, 0);
                drawData.shader = drawInfo.bodyArmorShader;
                Main.playerDrawData.Add(drawData);
            });

        public static readonly PlayerLayer CosmicTerrorBodyGlowmask = new PlayerLayer("JourneyTrend",
            "CosmicTerrorBodyGlowmask", PlayerLayer.Body, delegate(PlayerDrawInfo drawInfo)
            {
                if (drawInfo.shadow != 0f || drawInfo.drawPlayer.dead) return;
                var drawPlayer = drawInfo.drawPlayer;
                var mod = ModLoader.GetMod("JourneyTrend");
                if (drawPlayer.body != mod.GetEquipSlot("CosmicTerrorBody", EquipType.Body)) return;
                var texture = mod.GetTexture("Items/Vanity/CosmicTerror/CosmicTerrorBody_Glow");
                if (!drawPlayer.Male) texture = mod.GetTexture("Items/Vanity/CosmicTerror/CosmicTerrorBody_FemaleGlow");
                float drawX = (int) drawInfo.position.X + drawPlayer.width / 2;
                var drawY = (int) drawInfo.position.Y + drawPlayer.height - drawPlayer.bodyFrame.Height / 2 + 4f;
                var origin = drawInfo.bodyOrigin;
                var position = new Vector2(drawX, drawY) + drawPlayer.bodyPosition - Main.screenPosition;
                var alpha = (255 - drawPlayer.immuneAlpha) / 255f;
                var color = Color.White;
                var frame = drawPlayer.bodyFrame;
                var rotation = drawPlayer.bodyRotation;
                var spriteEffects = drawInfo.spriteEffects;
                var drawData = new DrawData(texture, position, frame, color * alpha, rotation, origin, 1f,
                    spriteEffects, 0);
                drawData.shader = drawInfo.bodyArmorShader;
                Main.playerDrawData.Add(drawData);
            });

        public static readonly PlayerLayer CosmicTerrorArmsGlowmask = new PlayerLayer("JourneyTrend",
            "CosmicTerrorArmsGlowmask", PlayerLayer.Arms, delegate(PlayerDrawInfo drawInfo)
            {
                if (drawInfo.shadow != 0f || drawInfo.drawPlayer.dead) return;
                var drawPlayer = drawInfo.drawPlayer;
                var mod = ModLoader.GetMod("JourneyTrend");
                if (drawPlayer.body != mod.GetEquipSlot("CosmicTerrorBody", EquipType.Body)) return;
                var texture = mod.GetTexture("Items/Vanity/CosmicTerror/CosmicTerrorBody_ArmsGlow");
                float drawX = (int) drawInfo.position.X + drawPlayer.width / 2;
                var drawY = (int) drawInfo.position.Y + drawPlayer.height - drawPlayer.bodyFrame.Height / 2 + 4f;
                var origin = drawInfo.bodyOrigin;
                var position = new Vector2(drawX, drawY) + drawPlayer.bodyPosition - Main.screenPosition;
                var alpha = (255 - drawPlayer.immuneAlpha) / 255f;
                var color = Color.White;
                var frame = drawPlayer.bodyFrame;
                var rotation = drawPlayer.bodyRotation;
                var spriteEffects = drawInfo.spriteEffects;
                var drawData = new DrawData(texture, position, frame, color * alpha, rotation, origin, 1f,
                    spriteEffects, 0);
                drawData.shader = drawInfo.bodyArmorShader;
                Main.playerDrawData.Add(drawData);
            });

        public static readonly PlayerLayer CosmicTerrorHeadGlowmask = new PlayerLayer("JourneyTrend",
            "CosmicTerrorHeadGlowmask", PlayerLayer.Head, delegate(PlayerDrawInfo drawInfo)
            {
                if (drawInfo.shadow != 0f || drawInfo.drawPlayer.dead) return;
                var drawPlayer = drawInfo.drawPlayer;
                var mod = ModLoader.GetMod("JourneyTrend");
                if (drawPlayer.head != mod.GetEquipSlot("CosmicTerrorHead", EquipType.Head)) return;
                var texture = mod.GetTexture("Items/Vanity/CosmicTerror/CosmicTerrorHead_Glow");
                float drawX = (int) drawInfo.position.X + drawPlayer.width / 2;
                var drawY = (int) drawInfo.position.Y + drawPlayer.height - drawPlayer.headFrame.Height / 2 + 4f - 34f;
                var origin = drawInfo.headOrigin;
                var position = new Vector2(drawX, drawY) + drawPlayer.headPosition - Main.screenPosition;
                var alpha = (255 - drawPlayer.immuneAlpha) / 255f;
                var color = Color.White;
                var frame = new Rectangle(0, drawPlayer.bodyFrame.Y, texture.Width, texture.Height / 20);
                var rotation = drawPlayer.headRotation;
                var spriteEffects = drawInfo.spriteEffects;
                var drawData = new DrawData(texture, position, frame, color * alpha, rotation, origin, 1f,
                    spriteEffects, 0);
                drawData.shader = drawInfo.headArmorShader;
                Main.playerDrawData.Add(drawData);
            });

        public static readonly PlayerLayer KnighwalkerHeadGlowmask = new PlayerLayer("JourneyTrend",
            "KnighwalkerHeadGlowmask", PlayerLayer.Head, delegate(PlayerDrawInfo drawInfo)
            {
                if (drawInfo.shadow != 0f || drawInfo.drawPlayer.dead) return;
                var drawPlayer = drawInfo.drawPlayer;
                var mod = ModLoader.GetMod("JourneyTrend");
                if (drawPlayer.head != mod.GetEquipSlot("KnightwalkerHead", EquipType.Head)) return;
                var texture = mod.GetTexture("Items/Vanity/Knightwalker/KnightwalkerHead_Glow");
                float drawX = (int) drawInfo.position.X + drawPlayer.width / 2;
                var drawY = (int) drawInfo.position.Y + drawPlayer.height - drawPlayer.headFrame.Height / 2 + 4f - 34f;
                var origin = drawInfo.headOrigin;
                var position = new Vector2(drawX, drawY) + drawPlayer.headPosition - Main.screenPosition;
                var alpha = (255 - drawPlayer.immuneAlpha) / 255f;
                var color = Color.White;
                var frame = new Rectangle(0, drawPlayer.bodyFrame.Y, texture.Width, texture.Height / 20);
                var rotation = drawPlayer.headRotation;
                var spriteEffects = drawInfo.spriteEffects;
                var drawData = new DrawData(texture, position, frame, color * alpha, rotation, origin, 1f,
                    spriteEffects, 0);
                drawData.shader = drawInfo.headArmorShader;
                Main.playerDrawData.Add(drawData);
            });

        public static readonly PlayerLayer DeepDiverHeadGlowmask = new PlayerLayer("JourneyTrend",
            "DeepDiverHeadGlowmask", PlayerLayer.Head, delegate(PlayerDrawInfo drawInfo)
            {
                if (drawInfo.shadow != 0f || drawInfo.drawPlayer.dead) return;
                var drawPlayer = drawInfo.drawPlayer;
                var mod = ModLoader.GetMod("JourneyTrend");
                if (drawPlayer.head != mod.GetEquipSlot("DeepDiverHead", EquipType.Head)) return;
                var texture = mod.GetTexture("Items/Vanity/DeepDiver/DeepDiverHead_Glow");
                float drawX = (int) drawInfo.position.X + drawPlayer.width / 2;
                var drawY = (int) drawInfo.position.Y + drawPlayer.height - drawPlayer.headFrame.Height / 2 + 4f - 34f;
                var origin = drawInfo.headOrigin;
                var position = new Vector2(drawX, drawY) + drawPlayer.headPosition - Main.screenPosition;
                var alpha = (255 - drawPlayer.immuneAlpha) / 255f;
                var color = Color.White;
                var frame = new Rectangle(0, drawPlayer.bodyFrame.Y, texture.Width, texture.Height / 20);
                var rotation = drawPlayer.headRotation;
                var spriteEffects = drawInfo.spriteEffects;
                var drawData = new DrawData(texture, position, frame, color * alpha, rotation, origin, 1f,
                    spriteEffects, 0);
                drawData.shader = drawInfo.headArmorShader;
                Main.playerDrawData.Add(drawData);
            });

        public static readonly PlayerLayer BountyHeadGlowmask = new PlayerLayer("JourneyTrend", "BountyHeadGlowmask",
            PlayerLayer.Head, delegate(PlayerDrawInfo drawInfo)
            {
                if (drawInfo.shadow != 0f || drawInfo.drawPlayer.dead) return;
                var drawPlayer = drawInfo.drawPlayer;
                var mod = ModLoader.GetMod("JourneyTrend");
                if (drawPlayer.head != mod.GetEquipSlot("BountyHead", EquipType.Head)) return;
                var texture = mod.GetTexture("Items/Vanity/Bounty/BountyHead_Glow");
                float drawX = (int) drawInfo.position.X + drawPlayer.width / 2;
                var drawY = (int) drawInfo.position.Y + drawPlayer.height - drawPlayer.headFrame.Height / 2 + 4f - 34f;
                var origin = drawInfo.headOrigin;
                var position = new Vector2(drawX, drawY) + drawPlayer.headPosition - Main.screenPosition;
                var alpha = (255 - drawPlayer.immuneAlpha) / 255f;
                var color = Color.White;
                var frame = new Rectangle(0, drawPlayer.bodyFrame.Y, texture.Width, texture.Height / 20);
                var rotation = drawPlayer.headRotation;
                var spriteEffects = drawInfo.spriteEffects;
                var drawData = new DrawData(texture, position, frame, color * alpha, rotation, origin, 1f,
                    spriteEffects, 0);
                drawData.shader = drawInfo.headArmorShader;
                Main.playerDrawData.Add(drawData);
            });

        public static readonly PlayerLayer StarlightDreamHeadGlowmask = new PlayerLayer("JourneyTrend",
            "StarlightDreamHeadGlowmask", PlayerLayer.Head, delegate(PlayerDrawInfo drawInfo)
            {
                if (drawInfo.shadow != 0f || drawInfo.drawPlayer.dead) return;
                var drawPlayer = drawInfo.drawPlayer;
                var mod = ModLoader.GetMod("JourneyTrend");
                if (drawPlayer.head != mod.GetEquipSlot("StarlightDreamHead", EquipType.Head)) return;
                var texture = mod.GetTexture("Items/Vanity/StarlightDream/StarlightDreamHead_Glow");
                float drawX = (int) drawInfo.position.X + drawPlayer.width / 2;
                var drawY = (int) drawInfo.position.Y + drawPlayer.height - drawPlayer.headFrame.Height / 2 + 4f - 34f;
                var origin = drawInfo.headOrigin;
                var position = new Vector2(drawX, drawY) + drawPlayer.headPosition - Main.screenPosition;
                var alpha = (255 - drawPlayer.immuneAlpha) / 255f;
                var color = Color.White;
                var frame = new Rectangle(0, drawPlayer.bodyFrame.Y, texture.Width, texture.Height / 20);
                var rotation = drawPlayer.headRotation;
                var spriteEffects = drawInfo.spriteEffects;
                var drawData = new DrawData(texture, position, frame, color * alpha, rotation, origin, 1f,
                    spriteEffects, 0);
                drawData.shader = drawInfo.headArmorShader;
                Main.playerDrawData.Add(drawData);
            });

        public static readonly PlayerLayer WitchsVoidHeadGlowmask = new PlayerLayer("JourneyTrend",
            "WitchsVoidHeadGlowmask", PlayerLayer.Head, delegate(PlayerDrawInfo drawInfo)
            {
                if (drawInfo.shadow != 0f || drawInfo.drawPlayer.dead) return;
                var drawPlayer = drawInfo.drawPlayer;
                var mod = ModLoader.GetMod("JourneyTrend");
                if (drawPlayer.head != mod.GetEquipSlot("WitchsVoidHead", EquipType.Head)) return;
                var texture = mod.GetTexture("Items/Vanity/WitchsVoid/WitchsVoidHead_Glow");
                float drawX = (int) drawInfo.position.X + drawPlayer.width / 2;
                var drawY = (int) drawInfo.position.Y + drawPlayer.height - drawPlayer.headFrame.Height / 2 + 4f - 34f;
                var origin = drawInfo.headOrigin;
                var position = new Vector2(drawX, drawY) + drawPlayer.headPosition - Main.screenPosition;
                var alpha = (255 - drawPlayer.immuneAlpha) / 255f;
                var color = Color.White;
                var frame = new Rectangle(0, drawPlayer.bodyFrame.Y, texture.Width, texture.Height / 20);
                var rotation = drawPlayer.headRotation;
                var spriteEffects = drawInfo.spriteEffects;
                var drawData = new DrawData(texture, position, frame, color * alpha, rotation, origin, 1f,
                    spriteEffects, 0);
                drawData.shader = drawInfo.headArmorShader;
                Main.playerDrawData.Add(drawData);
            });

        public static readonly PlayerLayer ShadowSpellHeadGlowmask = new PlayerLayer("JourneyTrend",
            "ShadowSpellHeadGlowmask", PlayerLayer.Head, delegate(PlayerDrawInfo drawInfo)
            {
                if (drawInfo.shadow != 0f || drawInfo.drawPlayer.dead) return;
                var drawPlayer = drawInfo.drawPlayer;
                var mod = ModLoader.GetMod("JourneyTrend");
                if (drawPlayer.head != mod.GetEquipSlot("ShadowSpellHead", EquipType.Head)) return;
                var texture = mod.GetTexture("Items/Vanity/ShadowSpell/ShadowSpellHead_Glow");
                float drawX = (int) drawInfo.position.X + drawPlayer.width / 2;
                var drawY = (int) drawInfo.position.Y + drawPlayer.height - drawPlayer.headFrame.Height / 2 + 4f - 34f;
                var origin = drawInfo.headOrigin;
                var position = new Vector2(drawX, drawY) + drawPlayer.headPosition - Main.screenPosition;
                var alpha = (255 - drawPlayer.immuneAlpha) / 255f;
                var color = Color.White;
                var frame = new Rectangle(0, drawPlayer.bodyFrame.Y, texture.Width, texture.Height / 20);
                var rotation = drawPlayer.headRotation;
                var spriteEffects = drawInfo.spriteEffects;
                var drawData = new DrawData(texture, position, frame, color * alpha, rotation, origin, 1f,
                    spriteEffects, 0);
                drawData.shader = drawInfo.headArmorShader;
                Main.playerDrawData.Add(drawData);
            });


        public bool BubbleheadHeadEquipped;
        private int BubbleheadHeadFrameCounter;
        private int BubbleheadHeadFrameUpdater;
        private int BubbleheadHeadTickToFrame;


        public bool doOffset; //used for the rookie hand offset (because it is lower than normal)


        // Idle Animating Fox Tails
        public bool FoxTailsEquipped;
        private bool isIdle; //true if not moving
        public bool KnightwalkerAlt;


        public bool KnightwalkerBodyEquipped; //corresponding equip bool
        private int KnightwalkerCapeFrameCounter;
        private int KnightwalkerCapeFrameUpdater;
        private int KnightwalkerCapeTickToFrame;
        private int KnightwalkerFlameFrameCounter;
        private int KnightwalkerFlameFrameUpdater;
        private int KnightwalkerFlameTickToFrame;


        public bool KnightwalkerHeadEquipped;
        private int KnightwalkerHeadFrameCounter;
        private int KnightwalkerHeadFrameUpdater;
        private int KnightwalkerHeadTickToFrame;
        public bool NinetailedFlying;
        private int NineTailedFrameCounter;
        private int NineTailedFrameUpdater;
        private int NineTailedTickToFrame;

        public bool StarlightBodyEquipped; // Corresponding equip bool

        private int walkUpShift; //-2 when the walk cykle has 'up' frames

        // Starting Items
        public override void SetupStartInventory(IList<Item> items, bool mediumcoreDeath)
        {
            var TravellerHead = new Item();
            TravellerHead.SetDefaults(ModContent.ItemType<TravellerHead>());
            TravellerHead.stack = 1;
            items.Add(TravellerHead);

            var TravellerBody = new Item();
            TravellerBody.SetDefaults(ModContent.ItemType<TravellerBody>());
            TravellerBody.stack = 1;
            items.Add(TravellerBody);

            var TravellerLegs = new Item();
            TravellerLegs.SetDefaults(ModContent.ItemType<TravellerLegs>());
            TravellerLegs.stack = 1;
            items.Add(TravellerLegs);
        }


        public override void PreUpdate()
        {
            if (player.velocity == Vector2.Zero)
                isIdle = true;
            else
                isIdle = false;

            //0,frameNum * frame hei, width, height
            var pl = player.bodyFrame.Y / 56;
            if (pl == 7 || pl == 8 || pl == 9 || pl == 14 || pl == 15 || pl == 16)
                walkUpShift = -2;
            else
                walkUpShift = 0;


            if (StarlightBodyEquipped) playerframe = player.bodyFrame; //grabs player rect

            if (KnightwalkerBodyEquipped)
            {
                if (player.grapCount > 0 && !isIdle) //when grappling and not not moving (grappled still)
                    //0,frameNum * frame hei, width, height 
                    playerframe = new Rectangle(0, 6 * (1120 / 20), 40, 1120 / 20);
                else
                    playerframe = player.bodyFrame; //grabs player rect
            }


            if (KnightwalkerBodyEquipped)
            {
                KnightwalkerFlameTickToFrame++;
                if (KnightwalkerFlameTickToFrame == 5) //every 5 ticks update
                {
                    KnightwalkerFlameFrameCounter++; //next frame
                    if (KnightwalkerFlameFrameCounter >= 8) //loop all frames from 0 to 7
                        KnightwalkerFlameFrameCounter = 0; //reset to first frame
                    KnightwalkerFlameTickToFrame = 0; //reset tick counter
                }

                if (isIdle)
                {
                    KnightwalkerCapeTickToFrame++;
                    if (KnightwalkerCapeTickToFrame == 8) //every 8 ticks update
                    {
                        KnightwalkerCapeFrameCounter++; //next frame
                        if (KnightwalkerCapeFrameCounter >= 20) //loop all frames from 0 to 20
                            KnightwalkerCapeFrameCounter = 0; //reset to first frame
                        KnightwalkerCapeTickToFrame = 0; //reset tick counter
                    }
                }
                else
                {
                    KnightwalkerCapeFrameCounter = 21; //set to empty frame when moving
                }
            }

            KnightwalkerFlameFrameUpdater = KnightwalkerFlameFrameCounter;
            KnightwalkerCapeFrameUpdater = KnightwalkerCapeFrameCounter;


            if (KnightwalkerHeadEquipped)
            {
                KnightwalkerHeadTickToFrame++;
                if (KnightwalkerHeadTickToFrame == 5) //every 5 ticks update
                {
                    KnightwalkerHeadFrameCounter++; //next frame
                    if (KnightwalkerHeadFrameCounter >= 8) //loop all frames from 0 to 7
                        KnightwalkerHeadFrameCounter = 0; //reset to first frame
                    KnightwalkerHeadTickToFrame = 0; //reset tick counter
                }
            }

            KnightwalkerHeadFrameUpdater = KnightwalkerHeadFrameCounter;


            if (BubbleheadHeadEquipped)
            {
                BubbleheadHeadTickToFrame++;
                if (BubbleheadHeadTickToFrame == 5) //every 5 ticks update
                {
                    BubbleheadHeadFrameCounter++; //next frame
                    if (BubbleheadHeadFrameCounter >= 14) //loop all frames from 0 to 7
                        BubbleheadHeadFrameCounter = 0; //reset to first frame
                    BubbleheadHeadTickToFrame = 0; //reset tick counter
                }
            }

            BubbleheadHeadFrameUpdater = BubbleheadHeadFrameCounter;


            if (FoxTailsEquipped) //foxTailsEquipped gets updated in NineTailedFoxAcc.cs
            {
                NineTailedTickToFrame++;
                if (NineTailedTickToFrame == 8) //every 8 ticks update
                {
                    NineTailedFrameCounter++; //next frame
                    if (NineTailedFrameCounter >= 10) //loop all frames from 0 to 9
                        NineTailedFrameCounter = 0; //reset to first frame
                    NineTailedTickToFrame = 0; //reset tick counter
                }

                if (!NinetailedFlying)
                    NineTailedFrameUpdater = NineTailedFrameCounter;
                else
                    NineTailedFrameUpdater = 10;
            }
        }

        public override void ResetEffects() //reset all the equip type booleans
        {
            FoxTailsEquipped = false;
            NinetailedFlying = false;
            StarlightBodyEquipped = false;
            KnightwalkerBodyEquipped = false;
            KnightwalkerHeadEquipped = false;
            BubbleheadHeadEquipped = false;
            isIdle = false;
        }

        //don't forget to add the layer below

        public override void ModifyDrawLayers(List<PlayerLayer> layers)
        {
            var legsIndex = layers.IndexOf(PlayerLayer.Skin);
            var headIndex = layers.IndexOf(PlayerLayer.Head);
            if (StarlightBodyEquipped)
            {
                layers.Insert(legsIndex - 1, StarlightDreamScarfGlow);
                layers.Insert(legsIndex - 1, StarlightDreamScarf);
            }

            if (KnightwalkerHeadEquipped) layers.Insert(legsIndex - 1, KnightwalkerHeadAddons);

            if (KnightwalkerBodyEquipped) layers.Insert(legsIndex - 1, KnightwalkerBodyAddons);

            if (BubbleheadHeadEquipped) layers.Insert(headIndex + 1, BubbleheadHeadAddons);

            if (FoxTailsEquipped) layers.Insert(legsIndex - 1, NineTailedFoxTail);

            var headLayer = layers.FindIndex(l => l == PlayerLayer.Head);
            var bodyLayer = layers.FindIndex(l => l == PlayerLayer.Body);
            var legsLayer = layers.FindIndex(l => l == PlayerLayer.Legs);
            if (headLayer > -1)
            {
                layers.Insert(headLayer + 1, ContainmentSuitHeadGlowmask);
                layers.Insert(headLayer + 1, CyberAngelHeadGlowmask);
                layers.Insert(headLayer + 1, MushroomHeadGlowmask);
                layers.Insert(headLayer + 1, NexusHeadGlowmask);
                layers.Insert(headLayer + 1, KnighwalkerHeadGlowmask);
                layers.Insert(headLayer + 1, DeepDiverHeadGlowmask);
                layers.Insert(headLayer + 1, BountyHeadGlowmask);
                layers.Insert(headLayer + 1, StarlightDreamHeadGlowmask);
                layers.Insert(headLayer + 1, WitchsVoidHeadGlowmask);
                layers.Insert(headLayer + 1, CosmicTerrorHeadGlowmask);
                layers.Insert(headLayer + 1, ShadowSpellHeadGlowmask);
            }

            if (bodyLayer > -1)
            {
                layers.Insert(bodyLayer + 1, ContainmentSuitBodyGlowmask);
                layers.Insert(bodyLayer + 1, CyberAngelBodyGlowmask);
                layers.Insert(bodyLayer + 1, MushroomBodyGlowmask);
                layers.Insert(bodyLayer + 1, NexusBodyGlowmask);
                layers.Insert(bodyLayer + 1, NightlightBodyGlowmask);
                layers.Insert(bodyLayer + 1, CosmicTerrorBodyGlowmask);
                var armsLayer = layers.FindIndex(l => l == PlayerLayer.Arms);
                if (armsLayer > -1)
                {
                    layers.Insert(armsLayer + 1, MushroomArmsGlowmask);
                    layers.Insert(armsLayer + 1, NexusArmsGlowmask);
                    layers.Insert(armsLayer + 1, CosmicTerrorArmsGlowmask);
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
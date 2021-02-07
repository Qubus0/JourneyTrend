using System;
using JourneyTrend.Items.Vanity.AndromedaPilot;
using JourneyTrend.Items.Vanity.ArcaneExosuit;
using JourneyTrend.Items.Vanity.Birdie;
using JourneyTrend.Items.Vanity.Bounty;
using JourneyTrend.Items.Vanity.BrokenHero;
using JourneyTrend.Items.Vanity.Bubblehead;
using JourneyTrend.Items.Vanity.ContainmentSuit;
using JourneyTrend.Items.Vanity.CosmicTerror;
using JourneyTrend.Items.Vanity.CrystalLegacy;
using JourneyTrend.Items.Vanity.CyberAngel;
using JourneyTrend.Items.Vanity.DeepDiver;
using JourneyTrend.Items.Vanity.Draugr;
using JourneyTrend.Items.Vanity.Duality;
using JourneyTrend.Items.Vanity.ForestDruid;
using JourneyTrend.Items.Vanity.Granite;
using JourneyTrend.Items.Vanity.Grid;
using JourneyTrend.Items.Vanity.HellWarden;
using JourneyTrend.Items.Vanity.Hivenet;
using JourneyTrend.Items.Vanity.IronCore;
using JourneyTrend.Items.Vanity.Journeyman;
using JourneyTrend.Items.Vanity.Kingfisher;
using JourneyTrend.Items.Vanity.KnightOfJudgement;
using JourneyTrend.Items.Vanity.Knightwalker;
using JourneyTrend.Items.Vanity.Kuijia;
using JourneyTrend.Items.Vanity.MagicGrill;
using JourneyTrend.Items.Vanity.Mothron;
using JourneyTrend.Items.Vanity.MushroomAlchemist;
using JourneyTrend.Items.Vanity.Nexus;
using JourneyTrend.Items.Vanity.Nightlight;
using JourneyTrend.Items.Vanity.NineTailedFox;
using JourneyTrend.Items.Vanity.Pilot;
using JourneyTrend.Items.Vanity.PoweredPanoply;
using JourneyTrend.Items.Vanity.Rookie;
using JourneyTrend.Items.Vanity.SeaBuckthornTea;
using JourneyTrend.Items.Vanity.SeaHunter;
using JourneyTrend.Items.Vanity.ShadowFiend;
using JourneyTrend.Items.Vanity.ShadowSpell;
using JourneyTrend.Items.Vanity.Shark;
using JourneyTrend.Items.Vanity.Shootsaton;
using JourneyTrend.Items.Vanity.StarlightDream;
using JourneyTrend.Items.Vanity.StormConqueror;
using JourneyTrend.Items.Vanity.SwampHorror;
using JourneyTrend.Items.Vanity.Terra;
using JourneyTrend.Items.Vanity.Traveller;
using JourneyTrend.Items.Vanity.Treesuit;
using JourneyTrend.Items.Vanity.WitchsVoid;
using JourneyTrend.Items.Vanity.WyvernRider;
using JourneyTrend.Tiles;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.Events;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using SewingMachine = JourneyTrend.Items.Placeable.SewingMachine;
using SewingMachineTile = JourneyTrend.Tiles.SewingMachine;

namespace JourneyTrend.NPCs.Trader
{
    [AutoloadHead]
    public class Trader : ModNPC
    {
        public override string Texture => "JourneyTrend/NPCs/Trader/Trader";
        //public override string[] AltTextures => new[] {"JourneyTrend/NPCs/Trader/Trader_Alt_1"};

        public override bool Autoload(ref string name)
        {
            name = "Vanity Trader";
            return mod.Properties.Autoload;
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Vanity Trader");
            Main.npcFrameCount[npc.type] = 25;
            NPCID.Sets.ExtraFramesCount[npc.type] = 9;
            NPCID.Sets.AttackFrameCount[npc.type] = 4;
            NPCID.Sets.DangerDetectRange[npc.type] = 700;
            NPCID.Sets.AttackType[npc.type] = 0;
            NPCID.Sets.AttackTime[npc.type] = 90;
            NPCID.Sets.AttackAverageChance[npc.type] = 30;
            NPCID.Sets.HatOffsetY[npc.type] = -8;
        }

        public override void SetDefaults()
        {
            npc.townNPC = true;
            npc.friendly = true;
            npc.width = 18;
            npc.height = 40;
            npc.aiStyle = 7;
            npc.damage = 10;
            npc.defense = 15;
            npc.lifeMax = 250;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.knockBackResist = 0.5f;
            animationType = NPCID.Guide;
        }

        public override string TownNPCName()
        {
            switch (WorldGen.genRand.Next(1))
            {
                case 0:
                    return "Bilbo Baggins";
                default:
                    return "Landry";
            }
        }

        public override void HitEffect(int hitDirection, double damage)
        {
            int num = npc.life > 0 ? 5 : 20;
            for (int k = 0; k < num; k++)
            {
                Dust.NewDust(npc.position, npc.width, npc.height, DustID.Silk);
            }
        }

        public override bool CanTownNPCSpawn(int numTownNPCs, int money)
        {
            for (int k = 0; k < 255; k++)
            {
                Player player = Main.player[k];
                if (!player.active)
                {
                    continue;
                }

                if (NPC.downedMoonlord)
                {
                    return true;
                }
            }

            return false;
        }

        public override bool CheckConditions(int left, int right, int top, int bottom)
        {
            int score = 0;
            for (int x = left; x <= right; x++)
            {
                for (int y = top; y <= bottom; y++)
                {
                    int type = Main.tile[x, y].type;
                    if (type == ModContent.TileType<SewingMachineTile>() || type == ItemID.Loom ||
                        type == ItemID.LivingLoom)
                    {
                        score += 10;
                    }
                }
            }

            return score >= (right - left) * (bottom - top) / 2;
        }

        public override string GetChat()
        {
            int clothier = NPC.FindFirstNPC(NPCID.Clothier);
            if (clothier >= 0 && Main.rand.NextBool(6))
            {
                return "Could you ask if " + Main.npc[clothier].GivenName +
                       " would sow some new outfits for me?";
            }

            int santa = NPC.FindFirstNPC(NPCID.SantaClaus);
            if (santa >= 0 && Main.rand.NextBool(6))
            {
                return "I have a bigger bag than " + Main.npc[santa].GivenName +
                       ". And a better outfit!";
            }

            int painter = NPC.FindFirstNPC(NPCID.Painter);
            if (painter >= 0 && Main.rand.NextBool(6))
            {
                return "Last time I met " + Main.npc[painter].GivenName +
                       " he got his paint all over me. I was barely able to wash it all out.";
            }

            int dyeTrader = NPC.FindFirstNPC(NPCID.DyeTrader);
            if (dyeTrader >= 0 && Main.rand.NextBool(6))
            {
                return Main.npc[dyeTrader].GivenName +
                       " really has the most beautiful colors. But I'm a little concerned about his obsession with strange plants.";
            }

            int vanityTrader = NPC.FindFirstNPC(ModContent.NPCType<Trader>());

            switch (Main.rand.Next(8))
            {
                case 0:
                    return "What? Oh, that. No I don't have a face.";
                case 1:
                    return "So you've never bought second hand before?";
                // {
                //     // Main.npcChatCornerItem shows a single item in the corner, like the Angler Quest chat.
                //     Main.npcChatCornerItem = ItemID.HiveBackpack;
                //     return $"Hey, if you find a [i:{ItemID.HiveBackpack}], I can upgrade it for you.";
                // }
                case 2:
                    return "What do you mean by »cosplay«?";
                case 3:
                    return "Majora? No, I don't know any Majora, why do you ask?";
                case 4:
                    return "Shirts? Armors? Fish bowls? It's yours, my friend, as long as you have enough coins!";
                case 5:
                    return "Got some rare things on sale, stranger!";
                case 6:
                    return Main.npc[vanityTrader].GivenName + " has wears if you have coin.";
                default:
                    return
                        $"Have you ever worked with a sewing machine [i:{ModContent.ItemType<SewingMachine>()}] before?";
            }
        }

        public override void SetChatButtons(ref string button, ref string button2)
        {
            button = Language.GetTextValue("LegacyInterface.28"); //shop
        }

        public override void OnChatButtonClicked(bool firstButton, ref bool shop)
        {
            if (firstButton)
            {
                Main.playerInventory = true;
                // remove the chat window...
                Main.npcChatText = "";
                shop = true;
            }
        }

        public override void SetupShop(Chest shop, ref int nextSlot)
        {
            const int bagPrice = 500;

            if (Main.dayTime)
            {
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<AndromedaPilotBag>());
                shop.item[nextSlot].shopCustomPrice = bagPrice;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<ArcaneExosuitBag>());
                shop.item[nextSlot].shopCustomPrice = bagPrice;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<BirdieBag>());
                shop.item[nextSlot].shopCustomPrice = bagPrice;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<BountyBag>());
                shop.item[nextSlot].shopCustomPrice = bagPrice;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<BrokenHeroBag>());
                shop.item[nextSlot].shopCustomPrice = bagPrice;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<BubbleheadBag>());
                shop.item[nextSlot].shopCustomPrice = bagPrice;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<ContainmentSuitBag>());
                shop.item[nextSlot].shopCustomPrice = bagPrice;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<CosmicTerrorBag>());
                shop.item[nextSlot].shopCustomPrice = bagPrice;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<CrystalLegacyBag>());
                shop.item[nextSlot].shopCustomPrice = bagPrice;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<CyberAngelBag>());
                shop.item[nextSlot].shopCustomPrice = bagPrice;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<DeepDiverBag>());
                shop.item[nextSlot].shopCustomPrice = bagPrice;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<DraugrBag>());
                shop.item[nextSlot].shopCustomPrice = bagPrice;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<DualityBag>());
                shop.item[nextSlot].shopCustomPrice = bagPrice;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<ForestDruidBag>());
                shop.item[nextSlot].shopCustomPrice = bagPrice;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<GraniteBag>());
                shop.item[nextSlot].shopCustomPrice = bagPrice;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<GridBag>());
                shop.item[nextSlot].shopCustomPrice = bagPrice;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<HellWardenBag>());
                shop.item[nextSlot].shopCustomPrice = bagPrice;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<HivenetBag>());
                shop.item[nextSlot].shopCustomPrice = bagPrice;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<IronCoreBag>());
                shop.item[nextSlot].shopCustomPrice = bagPrice;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<JourneymanBag>());
                shop.item[nextSlot].shopCustomPrice = bagPrice;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<KingfisherBag>());
                shop.item[nextSlot].shopCustomPrice = bagPrice;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<KnightOfJudgementBag>());
                shop.item[nextSlot].shopCustomPrice = bagPrice;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<KnightwalkerBag>());
                shop.item[nextSlot].shopCustomPrice = bagPrice;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<KuijiaBag>());
                shop.item[nextSlot].shopCustomPrice = bagPrice;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<MagicGrillBag>());
                shop.item[nextSlot].shopCustomPrice = bagPrice;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<MothronBag>());
                shop.item[nextSlot].shopCustomPrice = bagPrice;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<MushroomAlchemistBag>());
                shop.item[nextSlot].shopCustomPrice = bagPrice;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<NexusBag>());
                shop.item[nextSlot].shopCustomPrice = bagPrice;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<NightlightBag>());
                shop.item[nextSlot].shopCustomPrice = bagPrice;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<NineTailedFoxBag>());
                shop.item[nextSlot].shopCustomPrice = bagPrice;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<PilotBag>());
                shop.item[nextSlot].shopCustomPrice = bagPrice;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<PoweredPanoplyBag>());
                shop.item[nextSlot].shopCustomPrice = bagPrice;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<RookieBag>());
                shop.item[nextSlot].shopCustomPrice = bagPrice;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<SeaBuckthornTeaBag>());
                shop.item[nextSlot].shopCustomPrice = bagPrice;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<SeaHunterBag>());
                shop.item[nextSlot].shopCustomPrice = bagPrice;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<ShadowFiendBag>());
                shop.item[nextSlot].shopCustomPrice = bagPrice;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<ShadowSpellBag>());
                shop.item[nextSlot].shopCustomPrice = bagPrice;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<SharkBag>());
                shop.item[nextSlot].shopCustomPrice = bagPrice;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<ShootsatonBag>());
                shop.item[nextSlot].shopCustomPrice = bagPrice;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<StarlightDreamBag>());
                shop.item[nextSlot].shopCustomPrice = bagPrice;
                nextSlot++;
            }
            else
            {
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<StormConquerorBag>());
                shop.item[nextSlot].shopCustomPrice = bagPrice;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<SwampHorrorBag>());
                shop.item[nextSlot].shopCustomPrice = bagPrice;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<TerraBag>());
                shop.item[nextSlot].shopCustomPrice = bagPrice;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<TravellerBag>());
                shop.item[nextSlot].shopCustomPrice = bagPrice;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<TreesuitBag>());
                shop.item[nextSlot].shopCustomPrice = bagPrice;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<WitchsVoidBag>());
                shop.item[nextSlot].shopCustomPrice = bagPrice;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<WyvernRiderBag>());
                shop.item[nextSlot].shopCustomPrice = bagPrice;
                nextSlot++;
            }
        }

        public override bool CanGoToStatue(bool toKingStatue)
        {
            return true;
        }

        public override void TownNPCAttackStrength(ref int damage, ref float knockback)
        {
            damage = 30;
            knockback = 8f;
        }

        public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
        {
            cooldown = 30;
            randExtraCooldown = 20;
        }

        public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
        {
            projType = ProjectileID.Leaf;
            attackDelay = 1;
        }

        public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection,
            ref float randomOffset)
        {
            multiplier = 6f;
            randomOffset = 2f;
        }
    }
}
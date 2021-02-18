using System.Collections.Generic;
using JourneyTrend.Items.Placeable;
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
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using SewingMachineTile = JourneyTrend.Tiles.SewingMachine;

namespace JourneyTrend.NPCs.Trader
{
    [AutoloadHead]
    public class VanityTrader : ModNPC
    {
        private const int BagPrice = 50000; // same price for every bag

        public static List<Item> currentShop = new List<Item>();

        private static readonly int[] shopItems =
        {
            ModContent.ItemType<AndromedaPilotBag>(),
            ModContent.ItemType<ArcaneExosuitBag>(),
            ModContent.ItemType<BirdieBag>(),
            ModContent.ItemType<BountyBag>(),
            ModContent.ItemType<BrokenHeroBag>(),
            ModContent.ItemType<BubbleheadBag>(),
            ModContent.ItemType<ContainmentSuitBag>(),
            ModContent.ItemType<CosmicTerrorBag>(),
            ModContent.ItemType<CrystalLegacyBag>(),
            ModContent.ItemType<CyberAngelBag>(),
            ModContent.ItemType<DeepDiverBag>(),
            ModContent.ItemType<DraugrBag>(),
            ModContent.ItemType<DualityBag>(),
            ModContent.ItemType<ForestDruidBag>(),
            ModContent.ItemType<GraniteBag>(),
            ModContent.ItemType<GridBag>(),
            ModContent.ItemType<HellWardenBag>(),
            ModContent.ItemType<HivenetBag>(),
            ModContent.ItemType<IronCoreBag>(),
            ModContent.ItemType<JourneymanBag>(),
            ModContent.ItemType<KingfisherBag>(),
            ModContent.ItemType<KnightOfJudgementBag>(),
            ModContent.ItemType<KnightwalkerBag>(),
            ModContent.ItemType<KuijiaBag>(),
            ModContent.ItemType<MagicGrillBag>(),
            ModContent.ItemType<MothronBag>(),
            ModContent.ItemType<MushroomAlchemistBag>(),
            ModContent.ItemType<NexusBag>(),
            ModContent.ItemType<NightlightBag>(),
            ModContent.ItemType<NineTailedFoxBag>(),
            ModContent.ItemType<PilotBag>(),
            ModContent.ItemType<PoweredPanoplyBag>(),
            ModContent.ItemType<RookieBag>(),
            ModContent.ItemType<SeaBuckthornTeaBag>(),
            ModContent.ItemType<SeaHunterBag>(),
            ModContent.ItemType<ShadowFiendBag>(),
            ModContent.ItemType<ShadowSpellBag>(),
            ModContent.ItemType<SharkBag>(),
            ModContent.ItemType<ShootsatonBag>(),
            ModContent.ItemType<StarlightDreamBag>(),
            ModContent.ItemType<StormConquerorBag>(),
            ModContent.ItemType<SwampHorrorBag>(),
            ModContent.ItemType<TerraBag>(),
            ModContent.ItemType<TravellerBag>(),
            ModContent.ItemType<TreesuitBag>(),
            ModContent.ItemType<WitchsVoidBag>(),
            ModContent.ItemType<WyvernRiderBag>()
        };

        public override string Texture => "JourneyTrend/NPCs/Trader/VanityTrader";

        public static List<Item> CreateNewShop()
        {
            var itemIdList = new List<int>();
            for (var shopSlots = 0; shopSlots < Main.rand.Next(10, 20); shopSlots++)
            {
                var newItem = shopItems[Main.rand.Next(0, shopItems.Length)];
                while (itemIdList.Contains(newItem)) newItem = shopItems[Main.rand.Next(0, shopItems.Length)];

                itemIdList.Add(newItem);
            }

            var items = new List<Item>();
            foreach (var itemId in itemIdList)
            {
                var item = new Item();
                item.SetDefaults(itemId);
                items.Add(item);
            }

            return currentShop = items;
        }
        //public override string[] AltTextures => new[] {"JourneyTrend/NPCs/Trader/VanityTrader_Alt_1"};

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

        public static TagCompound Save()
        {
            return new TagCompound
            {
                ["currentShop"] = currentShop
            };
        }

        public static void Load(TagCompound tag)
        {
            currentShop = tag.Get<List<Item>>("currentShop");
        }

        public override string TownNPCName()
        {
            switch (WorldGen.genRand.Next(2))
            {
                case 0:
                    return "Landry";
                default:
                    return "Bilbo Baggins";
            }
        }

        public override void HitEffect(int hitDirection, double damage)
        {
            var num = npc.life > 0 ? 5 : 20;
            for (var k = 0; k < num; k++) Dust.NewDust(npc.position, npc.width, npc.height, DustID.Silk);

            if (npc.life <= 0) currentShop.Clear();
        }

        public override bool CanTownNPCSpawn(int numTownNPCs, int money)
        {
            for (var k = 0; k < 255; k++)
            {
                var player = Main.player[k];
                if (!player.active) continue;

                if (NPC.downedMoonlord) return true;
            }

            return false;
        }

        public override bool CheckConditions(int left, int right, int top, int bottom)
        {
            var score = 0;
            for (var x = left; x <= right; x++)
            for (var y = top; y <= bottom; y++)
            {
                int type = Main.tile[x, y].type;
                if (type == ModContent.TileType<SewingMachineTile>() || type == ItemID.Loom ||
                    type == ItemID.LivingLoom)
                    score += 10;
            }

            return score >= (right - left) * (bottom - top) / 2;
        }

        public override string GetChat()
        {
            var clothier = NPC.FindFirstNPC(NPCID.Clothier);
            if (clothier >= 0 && Main.rand.NextBool(6))
                return "Could you ask if " + Main.npc[clothier].GivenName +
                       " would sow some new outfits for me?";

            var painter = NPC.FindFirstNPC(NPCID.Painter);
            if (painter >= 0 && Main.rand.NextBool(6))
                return "Last time I met " + Main.npc[painter].GivenName +
                       " he got his paint all over me. I was barely able to wash it all out.";

            var dyeTrader = NPC.FindFirstNPC(NPCID.DyeTrader);
            if (dyeTrader >= 0 && Main.rand.NextBool(6))
                return Main.npc[dyeTrader].GivenName +
                       " really has the most beautiful colors. But I'm a little concerned about his obsession with strange plants.";

            var vanityTrader = NPC.FindFirstNPC(ModContent.NPCType<VanityTrader>());

            switch (Main.rand.Next(9))
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
                case 7:
                    return "Have you tried fried harpy wing before? Delicious.";
                default:
                    return
                        $"Have you ever worked with a sewing machine [i:{ModContent.ItemType<SewingMachine>()}] before?";
            }
        }

        public override void SetChatButtons(ref string button, ref string button2)
        {
            button = Language.GetTextValue("LegacyInterface.28"); //shop
            button2 = "Reroll Bags (10G)";
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
            else
            {
                Main.PlaySound(SoundID.Grab);
                Main.PlaySound(SoundID.Coins);
                Main.LocalPlayer.BuyItem(100000);
                Main.npcChatText = "";
                CreateNewShop();
                shop = true;
            }
        }

        public override void SetupShop(Chest shop, ref int nextSlot)
        {
            foreach (var item in currentShop)
            {
                // We dont want "empty" items and unloaded items to appear
                if (item == null || item.type == ItemID.None)
                    continue;

                shop.item[nextSlot].SetDefaults(item.type);
                shop.item[nextSlot].shopCustomPrice = BagPrice;
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
            projType = ProjectileID.NailFriendly;
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
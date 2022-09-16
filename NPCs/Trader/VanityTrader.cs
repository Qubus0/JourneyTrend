using System.Collections.Generic;
using JourneyTrend.Items.Placeable;
using JourneyTrend.Items.Vanity.AndromedaPilot;
using JourneyTrend.Items.Vanity.ArcaneExosuit;
using JourneyTrend.Items.Vanity.Birdie;
using JourneyTrend.Items.Vanity.BountyHunter;
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
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.Audio;
using Terraria.GameContent;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.Personalities;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.Utilities;
using SewingMachineTile = JourneyTrend.Tiles.SewingMachine;

namespace JourneyTrend.NPCs.Trader
{
    [AutoloadHead]
    public class VanityTrader : ModNPC
    {
        private const int BagPriceGold = 5; // same price for every bag
        private const int RestockPriceGold = 10;
        private string LastDialogue = "";

        public static List<Item> CurrentShop;

        private static readonly int[] ShopItems =
        {
            ModContent.ItemType<AndromedaPilotBag>(),
            ModContent.ItemType<ArcaneExosuitBag>(),
            ModContent.ItemType<BirdieBag>(),
            ModContent.ItemType<BountyHunterBag>(),
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
            ModContent.ItemType<WyvernRiderBag>(),
        };

        public static List<Item> CreateNewShop()
        {
            var itemIdList = new List<int>();
            for (var shopSlots = 0; shopSlots < Main.rand.Next(10, 20); shopSlots++)
            {
                var newItem = ShopItems[Main.rand.Next(0, ShopItems.Length)];
                while (itemIdList.Contains(newItem)) newItem = ShopItems[Main.rand.Next(0, ShopItems.Length)];

                itemIdList.Add(newItem);
            }

            var items = new List<Item>();
            foreach (var itemId in itemIdList)
            {
                var item = new Item();
                item.SetDefaults(itemId);
                items.Add(item);
            }

            return CurrentShop = items;
        }
        //public override string[] AltTextures => new[] {"JourneyTrend/NPCs/Trader/VanityTrader_Alt_1"};

        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[NPC.type] = 25;
            NPCID.Sets.ExtraFramesCount[NPC.type] = 9;
            NPCID.Sets.AttackFrameCount[NPC.type] = 4;
            NPCID.Sets.DangerDetectRange[NPC.type] = 700;
            NPCID.Sets.AttackType[NPC.type] = 0;
            NPCID.Sets.AttackTime[NPC.type] = 90;
            NPCID.Sets.AttackAverageChance[NPC.type] = 30;
            NPCID.Sets.HatOffsetY[NPC.type] = -8;

            NPC.Happiness
                .SetBiomeAffection<ForestBiome>(AffectionLevel.Love)
                .SetBiomeAffection<OceanBiome>(AffectionLevel.Like)
                .SetBiomeAffection<MushroomBiome>(AffectionLevel.Dislike)
                .SetBiomeAffection<CrimsonBiome>(AffectionLevel.Hate)
                .SetBiomeAffection<CorruptionBiome>(AffectionLevel.Hate)
                .SetNPCAffection(NPCID.Clothier, AffectionLevel.Like)
                .SetNPCAffection(NPCID.Stylist, AffectionLevel.Like)
                .SetNPCAffection(NPCID.DyeTrader, AffectionLevel.Like)
                ;
        }

        public override void SetDefaults()
        {
            NPC.townNPC = true;
            NPC.friendly = true;
            NPC.width = 18;
            NPC.height = 40;
            NPC.aiStyle = 7;
            NPC.damage = 10;
            NPC.defense = 15;
            NPC.lifeMax = 250;
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath1;
            NPC.knockBackResist = 0.5f;
            AnimationType = NPCID.Guide;
            CreateNewShop();
        }

        public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry) {
            // We can use AddRange instead of calling Add multiple times in order to add multiple items at once
            bestiaryEntry.Info.AddRange(new IBestiaryInfoElement[] {
                // Sets the preferred biomes of this town NPC listed in the bestiary.
                BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.Surface,
                new FlavorTextBestiaryInfoElement("Mods.JourneyTrend.Bestiary.VanityTrader"),
            });
        }

        public override void SaveData(TagCompound tag)
        {
            tag["CurrentShop"] = CurrentShop;
        }

        public override void LoadData(TagCompound tag)
        {
            CurrentShop = tag.Get<List<Item>>("CurrentShop");
        }

        public override ITownNPCProfile TownNPCProfile() {
        	return new VanityTraderProfile();
        }

        public override List<string> SetNPCNameList()
        {
            return new List<string> {
                "Landry",
                "Bilbo Baggins",
                "Mad Hat Vendor",
                "Happy Bag Salesman",
                "Carl",
                "Joe",
                "Bagton",
            };
        }

        public override void HitEffect(int hitDirection, double damage)
        {
            var num = NPC.life > 0 ? 5 : 20;
            for (var k = 0; k < num; k++) Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.Silk);

            if (NPC.life <= 0) CurrentShop.Clear();
        }

        public override bool CanTownNPCSpawn(int numTownNpcs, int money)
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
            for (var x = left; x <= right; x++)
            for (var y = top; y <= bottom; y++)
            {
                int tileType = Main.tile[x, y].TileType;
                if (tileType == ModContent.TileType<SewingMachineTile>() || tileType == TileID.Loom || tileType == TileID.LivingLoom)
                    return true;
            }

            return false;
        }

        public override string GetChat()
        {
            WeightedRandom<string> dialogue = new WeightedRandom<string>();

            var clothier = NPC.FindFirstNPC(NPCID.Clothier);
            if (clothier >= 0)
                dialogue.Add(Language.GetTextValue("Mods.JourneyTrend.Dialogue.VanityTrader.ClothierDialogue", Main.npc[clothier].GivenName));

            var painter = NPC.FindFirstNPC(NPCID.Painter);
            if (painter >= 0)
                dialogue.Add(Language.GetTextValue("Mods.JourneyTrend.Dialogue.VanityTrader.PainterDialogue", Main.npc[painter].GivenName));

            var dyeTrader = NPC.FindFirstNPC(NPCID.DyeTrader);
            if (dyeTrader >= 0)
                dialogue.Add(Language.GetTextValue("Mods.JourneyTrend.Dialogue.VanityTrader.DyeTraderDialogue", Main.npc[dyeTrader].GivenName));

            var vanityTrader = NPC.FindFirstNPC(ModContent.NPCType<VanityTrader>());
            if (Main.npc[vanityTrader].GivenName == "Carl")
            {
                dialogue.Add(Language.GetTextValue("Mods.JourneyTrend.Dialogue.VanityTrader.NamedCarl1"), 0.5);
                dialogue.Add(Language.GetTextValue("Mods.JourneyTrend.Dialogue.VanityTrader.NamedCarl2"), 0.5);
            }

            dialogue.Add(Language.GetTextValue("Mods.JourneyTrend.Dialogue.VanityTrader.SewingMachine" , ModContent.ItemType<SewingMachine>()), 1.5);
            dialogue.Add(Language.GetTextValue("Mods.JourneyTrend.Dialogue.VanityTrader.RareDialogue"), 0.2);
            dialogue.Add( Language.GetTextValue("Mods.JourneyTrend.Dialogue.VanityTrader.SelfDialogue", Main.npc[vanityTrader].GivenName));
            
            dialogue.Add(Language.GetTextValue("Mods.JourneyTrend.Dialogue.VanityTrader.StandardDialogue1"));
            dialogue.Add(Language.GetTextValue("Mods.JourneyTrend.Dialogue.VanityTrader.StandardDialogue2"));
            dialogue.Add(Language.GetTextValue("Mods.JourneyTrend.Dialogue.VanityTrader.StandardDialogue3"));
            dialogue.Add(Language.GetTextValue("Mods.JourneyTrend.Dialogue.VanityTrader.StandardDialogue4"));
            dialogue.Add(Language.GetTextValue("Mods.JourneyTrend.Dialogue.VanityTrader.StandardDialogue5"));
            dialogue.Add(Language.GetTextValue("Mods.JourneyTrend.Dialogue.VanityTrader.StandardDialogue6"));

            var chosenDialogue = (string)dialogue;
            if (chosenDialogue != LastDialogue) // don't say the same thing twice in a row
            {
                LastDialogue = chosenDialogue;
                return chosenDialogue;
            }

            return GetChat(); 
        }

        public override void SetChatButtons(ref string button, ref string button2)
        {
            button = Language.GetTextValue("LegacyInterface.28"); // shop
            button2 = Language.GetTextValue("Mods.JourneyTrend.NpcShopButtons.VanityTrader.button2", RestockPriceGold);
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
                SoundEngine.PlaySound(SoundID.Grab);
                SoundEngine.PlaySound(SoundID.Coins);
                Main.LocalPlayer.BuyItem(RestockPriceGold * 10000);
                Main.npcChatText = "";
                CreateNewShop();
                shop = true;
            }
        }

        public override void SetupShop(Chest shop, ref int nextSlot)
        {
            foreach (var item in CurrentShop)
            {
                // We dont want "empty" items and unloaded items to appear
                if (item == null || item.type == ItemID.None)
                    continue;

                shop.item[nextSlot].SetDefaults(item.type);
                shop.item[nextSlot].shopCustomPrice = BagPriceGold * 10000;
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

        private class VanityTraderProfile : ITownNPCProfile
        {
            public int RollVariation() => 0;
            public string GetNameForVariant(NPC npc) => npc.getNewNPCName();

            public Asset<Texture2D> GetTextureNPCShouldUse(NPC npc) {
                // if (npc.IsABestiaryIconDummy && !npc.ForcePartyHatOn)
                //     return ModContent.Request<Texture2D>("JourneyTrend/NPCs/Trader/VanityTrader");
                //
                // if (npc.altTexture == 1)
                //     return ModContent.Request<Texture2D>("JourneyTrend/NPCs/Trader/VanityTrader");

                return ModContent.Request<Texture2D>("JourneyTrend/NPCs/Trader/VanityTrader");
            }

            public int GetHeadTextureIndex(NPC npc) => ModContent.GetModHeadSlot("JourneyTrend/NPCs/Trader/VanityTrader_Head");
        }
    }
}
using System.Collections.Generic;
using System.Linq;
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
using JourneyTrend.Items.Vanity.Planetary;
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
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.Audio;
using Terraria.Chat;
using Terraria.DataStructures;
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
        private const int BagPricePlat = 1; // same price for every bag
        private const int RestockPricePlat = 3;
        private const int PlatMultiplier = 1_000_000;

        private const int BagPrice = BagPricePlat * PlatMultiplier;
        private const int RestockPrice = RestockPricePlat * PlatMultiplier;

        private string LastDialogue = "";

        // A static instance of the declarative shop, defining all the items which can be brought.
        // Used to create a new inventory when the NPC spawns
        public static VanitySetShop Shop;
        public List<Item> CurrentShopItems;

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
        }

        public override void OnSpawn(IEntitySource source) => CreateNewShop();

        public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry)
        {
            // We can use AddRange instead of calling Add multiple times in order to add multiple items at once
            bestiaryEntry.Info.AddRange(new IBestiaryInfoElement[]
            {
                // Sets the preferred biomes of this town NPC listed in the bestiary.
                BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.Surface,
                new FlavorTextBestiaryInfoElement("Mods.JourneyTrend.Bestiary.VanityTrader"),
            });
        }
        
        public override bool PreAI() {
            if (Main.dayTime && Main.time == 0)
                CreateNewShop();

            return true;
        }

        public override void SaveData(TagCompound tag)
        {
            tag["CurrentShopItems"] = CurrentShopItems;
        }

        public override void LoadData(TagCompound tag)
        {
            CurrentShopItems = tag.Get<List<Item>>("CurrentShopItems");
        }

        public override ITownNPCProfile TownNPCProfile()
        {
            return new VanityTraderProfile();
        }

        public override List<string> SetNPCNameList()
        {
            return new List<string>
            {
                "Landry",
                "Bilbo Baggins",
                "Mad Hat Vendor",
                "Happy Bag Salesman",
                "Carl",
                "Joe",
                "Bagton",
                "Jimmy",
            };
        }

        public override void HitEffect(NPC.HitInfo hit)
        {
            int num = NPC.life > 0 ? 5 : 20;
            for (int k = 0; k < num; k++) Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.Silk);

            if (NPC.life <= 0) CurrentShopItems.Clear();
        }

        public override bool CanTownNPCSpawn(int numTownNpcs)
        {
            for (int k = 0; k < 255; k++)
            {
                var player = Main.player[k];
                if (!player.active) continue;

                if (NPC.downedMoonlord) return true;
            }

            return false;
        }

        public override bool CheckConditions(int left, int right, int top, int bottom)
        {
            for (int x = left; x <= right; x++)
            for (int y = top; y <= bottom; y++)
            {
                int tileType = Main.tile[x, y].TileType;
                
                if (tileType == ModContent.TileType<SewingMachineTile>()
                    || tileType == TileID.Loom
                    || tileType == TileID.LivingLoom)
                    return true;
            }

            return false;
        }

        public override string GetChat()
        {
            WeightedRandom<string> dialogue = new WeightedRandom<string>();

            var clothier = NPC.FindFirstNPC(NPCID.Clothier);
            const string vanityTraderDialog = "Mods.JourneyTrend.Dialogue.VanityTrader";

            if (clothier >= 0)
                dialogue.Add(Language.GetTextValue(vanityTraderDialog + ".ClothierDialogue",
                    Main.npc[clothier].GivenName));

            var painter = NPC.FindFirstNPC(NPCID.Painter);
            if (painter >= 0)
                dialogue.Add(
                    Language.GetTextValue(vanityTraderDialog + ".PainterDialogue", Main.npc[painter].GivenName));

            var dyeTrader = NPC.FindFirstNPC(NPCID.DyeTrader);
            if (dyeTrader >= 0)
                dialogue.Add(Language.GetTextValue(vanityTraderDialog + ".DyeTraderDialogue",
                    Main.npc[dyeTrader].GivenName));

            var vanityTrader = NPC.FindFirstNPC(ModContent.NPCType<VanityTrader>());
            if (Main.npc[vanityTrader].GivenName == "Carl")
            {
                dialogue.Add(Language.GetTextValue(vanityTraderDialog + ".NamedCarl1"), 0.5);
                dialogue.Add(Language.GetTextValue(vanityTraderDialog + ".NamedCarl2"), 0.5);
            }

            dialogue.Add(
                Language.GetTextValue(vanityTraderDialog + ".SewingMachine", ModContent.ItemType<SewingMachine>()),
                1.5);
            dialogue.Add(Language.GetTextValue(vanityTraderDialog + ".RareDialogue"), 0.2);
            dialogue.Add(Language.GetTextValue(vanityTraderDialog + ".SelfDialogue", Main.npc[vanityTrader].GivenName));

            dialogue.Add(Language.GetTextValue(vanityTraderDialog + ".StandardDialogue1"));
            dialogue.Add(Language.GetTextValue(vanityTraderDialog + ".StandardDialogue2"));
            dialogue.Add(Language.GetTextValue(vanityTraderDialog + ".StandardDialogue3"));
            dialogue.Add(Language.GetTextValue(vanityTraderDialog + ".StandardDialogue4"));
            dialogue.Add(Language.GetTextValue(vanityTraderDialog + ".StandardDialogue5"));
            dialogue.Add(Language.GetTextValue(vanityTraderDialog + ".StandardDialogue6"));

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
            button2 = Language.GetTextValue("Mods.JourneyTrend.NpcShopButtons.VanityTrader.button2", RestockPricePlat);
        }

        public override void OnChatButtonClicked(bool firstButton, ref string shopName)
        {
            if (firstButton)
            {
                Main.playerInventory = true;
                // remove the chat window...
                Main.npcChatText = "";
                // open the shop window
                shopName = "Shop";
            }
            else
            {
                // restock
                SoundEngine.PlaySound(SoundID.Grab);
                SoundEngine.PlaySound(SoundID.Coins);
                Main.LocalPlayer.BuyItem(RestockPricePlat * PlatMultiplier);
                // remove the chat window...
                Main.npcChatText = "";
                CreateNewShop();
                // open the shop window
                shopName = "Shop";
            }
        }

        private void CreateNewShop()
        {
            CurrentShopItems = Shop.GenerateNewInventoryList();
            const string refreshMessage = "Mods.JourneyTrend.Chat.VanityTraderShopRestock";
            if (Main.netMode == NetmodeID.SinglePlayer) Main.NewText(Language.GetTextValue(refreshMessage, NPC.FullName), 50, 205, 151);
            else ChatHelper.BroadcastChatMessage(NetworkText.FromKey(refreshMessage, NPC.GetFullNetName()), new Color(50, 205, 151));
        }

        public override void AddShops()
        {
            Shop = new VanitySetShop(NPC.type);
            
            // https://forums.terraria.org/index.php?threads/journeys-end-vanity-contest-finalists-voting-instructions.87511/
            Shop.AddPool("Finalists", slots: 2)
                .AddPriced<TravellerBag>(BagPrice)
                .AddPriced<ForestDruidBag>(BagPrice)
                .AddPriced<BubbleheadBag>(BagPrice)
                .AddPriced<SwampHorrorBag>(BagPrice)
                .AddPriced<CyberAngelBag>(BagPrice)
                .AddPriced<WyvernRiderBag>(BagPrice)
                .AddPriced<WitchsVoidBag>(BagPrice)
                .AddPriced<StarlightDreamBag>(BagPrice)
                .AddPriced<MagicGrillBag>(BagPrice)
                .AddPriced<DeepDiverBag>(BagPrice)
                .AddPriced<CosmicTerrorBag>(BagPrice)
                .AddPriced<NightlightBag>(BagPrice)
                .AddPriced<ContainmentSuitBag>(BagPrice)
                .AddPriced<MushroomAlchemistBag>(BagPrice)
                ;
            
            Shop.AddPool("Vanities", slots: 7)
                .AddPriced<AndromedaPilotBag>(BagPrice)
                .AddPriced<ArcaneExosuitBag>(BagPrice)
                .AddPriced<BirdieBag>(BagPrice)
                .AddPriced<BountyHunterBag>(BagPrice)
                .AddPriced<BrokenHeroBag>(BagPrice)
                .AddPriced<CrystalLegacyBag>(BagPrice)
                .AddPriced<DraugrBag>(BagPrice)
                .AddPriced<DualityBag>(BagPrice)
                .AddPriced<GraniteBag>(BagPrice)
                .AddPriced<GridBag>(BagPrice)
                .AddPriced<HellWardenBag>(BagPrice)
                .AddPriced<HivenetBag>(BagPrice)
                .AddPriced<IronCoreBag>(BagPrice)
                .AddPriced<JourneymanBag>(BagPrice)
                .AddPriced<KingfisherBag>(BagPrice)
                .AddPriced<KnightOfJudgementBag>(BagPrice)
                .AddPriced<KnightwalkerBag>(BagPrice)
                .AddPriced<KuijiaBag>(BagPrice)
                .AddPriced<MothronBag>(BagPrice)
                .AddPriced<NexusBag>(BagPrice)
                .AddPriced<NineTailedFoxBag>(BagPrice)
                .AddPriced<PilotBag>(BagPrice)
                .AddPriced<PlanetaryBag>(BagPrice)
                .AddPriced<PoweredPanoplyBag>(BagPrice)
                .AddPriced<RookieBag>(BagPrice)
                .AddPriced<SeaBuckthornTeaBag>(BagPrice)
                .AddPriced<SeaHunterBag>(BagPrice)
                .AddPriced<ShadowFiendBag>(BagPrice)
                .AddPriced<ShadowSpellBag>(BagPrice)
                .AddPriced<SharkBag>(BagPrice)
                .AddPriced<ShootsatonBag>(BagPrice)
                .AddPriced<StormConquerorBag>(BagPrice)
                .AddPriced<TerraBag>(BagPrice)
                .AddPriced<TreesuitBag>(BagPrice)
                ;

            Shop.Register();
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

            public Asset<Texture2D> GetTextureNPCShouldUse(NPC npc)
            {
                // not used
                // if (npc.IsABestiaryIconDummy && !npc.ForcePartyHatOn)
                //     return ModContent.Request<Texture2D>("JourneyTrend/NPCs/Trader/VanityTrader");
                //
                // if (npc.altTexture == 1)
                //     return ModContent.Request<Texture2D>("JourneyTrend/NPCs/Trader/VanityTrader");

                return ModContent.Request<Texture2D>("JourneyTrend/NPCs/Trader/VanityTrader");
            }

            public int GetHeadTextureIndex(NPC npc) =>
                ModContent.GetModHeadSlot("JourneyTrend/NPCs/Trader/VanityTrader_Head");
        }
    }

    // taken from example mod
    public class VanitySetShop : AbstractNPCShop
    {
        public new record Entry(Item Item, List<Condition> Conditions) : AbstractNPCShop.Entry
        {
            IEnumerable<Condition> AbstractNPCShop.Entry.Conditions => Conditions;

            public bool Disabled { get; private set; }

            public Entry Disable()
            {
                Disabled = true;
                return this;
            }

            public bool ConditionsMet() => Conditions.All(c => c.IsMet());
        }

        public record Pool(string Name, int Slots, List<Entry> Entries)
        {
            public Pool Add(Item item, params Condition[] conditions)
            {
                Entries.Add(new Entry(item, conditions.ToList()));
                return this;
            }

            public Pool Add<T>(params Condition[] conditions) where T : ModItem =>
                Add(ModContent.ItemType<T>(), conditions);

            public Pool AddPriced<T>(int itemPrice, params Condition[] conditions) where T : ModItem => Add(
                new Item(ModContent.ItemType<T>()) { shopCustomPrice = itemPrice },
                conditions
            );

            public Pool Add(int item, params Condition[] conditions) =>
                Add(ContentSamples.ItemsByType[item], conditions);

            // Picks a number of items (up to Slots) from the entries list, provided conditions are met.
            public IEnumerable<Item> PickItems()
            {
                // This is not a fast way to pick items without replacement, but it's certainly easy. Be careful not to do this many many times per frame, or on huge lists of items.
                var list = Entries.Where(e => !e.Disabled && e.ConditionsMet()).ToList();
                for (int i = 0; i < Slots; i++)
                {
                    if (list.Count == 0)
                        break;

                    int k = Main.rand.Next(list.Count);
                    yield return list[k].Item;

                    // remove the entry from the list so it can't be selected again this pick
                    list.RemoveAt(k);
                }
            }
        }

        public List<Pool> Pools { get; } = new();

        public VanitySetShop(int npcType) : base(npcType)
        {
        }

        public override IEnumerable<Entry> ActiveEntries => Pools.SelectMany(p => p.Entries).Where(e => !e.Disabled);

        public Pool AddPool(string name, int slots)
        {
            var pool = new Pool(name, slots, new List<Entry>());
            Pools.Add(pool);
            return pool;
        }

        // Some methods to add a pool with a single item
        public void Add(Item item, params Condition[] conditions) =>
            AddPool(item.ModItem?.FullName ?? $"Terraria/{item.type}", slots: 1).Add(item, conditions);

        public void Add<T>(params Condition[] conditions) where T : ModItem =>
            Add(ModContent.ItemType<T>(), conditions);

        public void Add(int item, params Condition[] conditions) => Add(ContentSamples.ItemsByType[item], conditions);

        // Here is where we actually 'roll' the contents of the shop
        public List<Item> GenerateNewInventoryList()
        {
            var items = new List<Item>();
            foreach (var pool in Pools)
            {
                items.AddRange(pool.PickItems());
            }

            return items;
        }

        public override void FillShop(ICollection<Item> items, NPC npc)
        {
            // use the items which were selected when the NPC spawned.
            foreach (var item in ((VanityTrader)npc.ModNPC).CurrentShopItems)
            {
                // make sure to add a clone of the item, in case any ModifyActiveShop hooks adjust the item when the shop is opened
                items.Add(item.Clone());
            }
        }

        public override void FillShop(Item[] items, NPC npc, out bool overflow)
        {
            overflow = false;
            int i = 0;
            // use the items which were selected when the NPC spawned.
            foreach (var item in ((VanityTrader)npc.ModNPC).CurrentShopItems)
            {
                if (i == items.Length - 1)
                {
                    // leave the last slot empty for selling
                    overflow = true;
                    return;
                }

                // make sure to add a clone of the item, in case any ModifyActiveShop hooks adjust the item when the shop is opened
                items[i++] = item.Clone();
            }
        }
    }
}
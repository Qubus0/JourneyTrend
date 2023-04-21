using System.Collections.Generic;
using JourneyTrend.Items.Placeable;
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
    public partial class VanityTrader : ModNPC
    {
        private const int BagPriceGold = 5 * 10000; // same price for every bag
        private const int RestockPriceGold = 10 * 10000;
        private string LastDialogue = "";

        public static List<Item> CurrentShop;

        public static List<Item> CreateNewShop()
        {
            var itemIdList = new List<int>();
            for (var shopSlots = 0; shopSlots < Main.rand.Next(7, 15); shopSlots++)
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
                "Jimmy",
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
            const string vanityTraderDialog = "Mods.JourneyTrend.Dialogue.VanityTrader";
            
            if (clothier >= 0)
                dialogue.Add(Language.GetTextValue(vanityTraderDialog + ".ClothierDialogue", Main.npc[clothier].GivenName));

            var painter = NPC.FindFirstNPC(NPCID.Painter);
            if (painter >= 0)
                dialogue.Add(Language.GetTextValue(vanityTraderDialog + ".PainterDialogue", Main.npc[painter].GivenName));

            var dyeTrader = NPC.FindFirstNPC(NPCID.DyeTrader);
            if (dyeTrader >= 0)
                dialogue.Add(Language.GetTextValue(vanityTraderDialog + ".DyeTraderDialogue", Main.npc[dyeTrader].GivenName));

            var vanityTrader = NPC.FindFirstNPC(ModContent.NPCType<VanityTrader>());
            if (Main.npc[vanityTrader].GivenName == "Carl")
            {
                dialogue.Add(Language.GetTextValue(vanityTraderDialog + ".NamedCarl1"), 0.5);
                dialogue.Add(Language.GetTextValue(vanityTraderDialog + ".NamedCarl2"), 0.5);
            }

            dialogue.Add(Language.GetTextValue(vanityTraderDialog + ".SewingMachine" , ModContent.ItemType<SewingMachine>()), 1.5);
            dialogue.Add(Language.GetTextValue(vanityTraderDialog + ".RareDialogue"), 0.2);
            dialogue.Add( Language.GetTextValue(vanityTraderDialog + ".SelfDialogue", Main.npc[vanityTrader].GivenName));
            
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
                Main.LocalPlayer.BuyItem(RestockPriceGold);
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
                shop.item[nextSlot].shopCustomPrice = BagPriceGold;
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
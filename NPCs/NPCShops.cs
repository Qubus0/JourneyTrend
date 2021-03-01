using JourneyTrend.Items.Vanity.ArcaneExosuit;
using JourneyTrend.Items.Vanity.Birdie;
using JourneyTrend.Items.Vanity.Bounty;
using JourneyTrend.Items.Vanity.CyberAngel;
using JourneyTrend.Items.Vanity.DeepDiver;
using JourneyTrend.Items.Vanity.Grid;
using JourneyTrend.Items.Vanity.Journeyman;
using JourneyTrend.Items.Vanity.MushroomAlchemist;
using JourneyTrend.Items.Vanity.NineTailedFox;
using JourneyTrend.Items.Vanity.SeaBuckthornTea;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyTrend.NPCs
{
    public class NPCShops : GlobalNPC
    {
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            switch (type)
            {
                case NPCID.WitchDoctor:
                    if (Main.player[Main.myPlayer].ZoneJungle && Main.bloodMoon)
                    {
                        // 5 Gold from Witch Doctor, during Blood Moon, in Jungle - Single Item - Arcane Exosuit Set
                        shop.item[nextSlot].SetDefaults(ItemType<ArcaneExosuitHead>());
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(ItemType<ArcaneExosuitBody>());
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(ItemType<ArcaneExosuitLegs>());
                        nextSlot++;
                    }

                    break;

                case NPCID.DD2Bartender:
                    // 25 Gold from Tavernkeep - Single Item - Sea Buckthorn Tea Set
                    shop.item[nextSlot].SetDefaults(ItemType<SeaBuckthornTeaHead>());
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemType<SeaBuckthornTeaBody>());
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemType<SeaBuckthornTeaLegs>());
                    nextSlot++;
                    break;

                case NPCID.Cyborg:
                    if (Main.player[Main.myPlayer].ZoneJungle && Main.invasionType == 4)
                    {
                        // 50 Gold from Cyborg, during Martian Madness, in Jungle - Single Item - Grid's Set
                        shop.item[nextSlot].SetDefaults(ItemType<GridHead>());
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(ItemType<GridBody>());
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(ItemType<GridLegs>());
                        nextSlot++;
                    }

                    if (!Main.dayTime && NPC.downedMartians)
                    {
                        shop.item[nextSlot].SetDefaults(ItemType<BountyHead>());
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(ItemType<BountyBody>());
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(ItemType<BountyLegs>());
                        nextSlot++;
                    }

                    if (Main.dayTime)
                    {
                        shop.item[nextSlot].SetDefaults(ItemType<CyberAngelHead>());
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(ItemType<CyberAngelBody>());
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(ItemType<CyberAngelLegs>());
                        nextSlot++;
                    }

                    break;

                case NPCID.Clothier:
                    // 5 Gold from Clothier (to change to Golfer post 1.4...)
                    shop.item[nextSlot].SetDefaults(ItemType<BirdieHead>());
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemType<BirdieBody>());
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemType<BirdieLegs>());
                    nextSlot++;
                    break;

                case NPCID.Pirate:
                    if (Main.raining)
                    {
                        shop.item[nextSlot].SetDefaults(ItemType<DeepDiverHead>());
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(ItemType<DeepDiverBody>());
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(ItemType<DeepDiverLegs>());
                        nextSlot++;
                    }

                    break;

                case NPCID.Truffle:
                    shop.item[nextSlot].SetDefaults(ItemType<MushroomAlchemistHead>());
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemType<MushroomAlchemistBody>());
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemType<MushroomAlchemistLegs>());
                    nextSlot++;
                    break;
            }
        }

        public override void SetupTravelShop(int[] shop, ref int nextSlot)
        {
            if (Main.moonPhase == 6)
            {
                // 15 Gold from Travelling Merchant, First Quarter Moon - Single Item - Journeyman Set
                shop[nextSlot] = ItemType<JourneymanHead>();
                nextSlot++;
            }

            if (Main.moonPhase == 0)
            {
                // 15 Gold from Travelling Merchant, Full Moon - Single Item - Journeyman Set
                shop[nextSlot] = ItemType<JourneymanBody>();
                nextSlot++;
            }

            if (Main.moonPhase == 2)
            {
                // 15 Gold from Travelling Merchant, Third Quarter Moon - Single Item - Journeyman Set
                shop[nextSlot] = ItemType<JourneymanLegs>();
                nextSlot++;
            }

            shop[nextSlot] = ItemType<NineTailedFoxHead>();
            nextSlot++;
            shop[nextSlot] = ItemType<NineTailedFoxBody>();
            nextSlot++;
            shop[nextSlot] = ItemType<NineTailedFoxLegs>();
            nextSlot++;
            shop[nextSlot] = ItemType<NineTailedFoxAcc>();
            nextSlot++;
        }
    }
}
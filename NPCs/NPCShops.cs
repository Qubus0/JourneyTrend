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
                        shop.item[nextSlot].SetDefaults(ItemType<Items.Vanity.ArcaneExosuit.ArcaneExosuitLegs>());
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(ItemType<Items.Vanity.ArcaneExosuit.ArcaneExosuitLegs>());
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(ItemType<Items.Vanity.ArcaneExosuit.ArcaneExosuitLegs>());
                        nextSlot++;
                    }
                    break;

                case NPCID.DD2Bartender:
                    // 25 Gold from Tavernkeep - Single Item - Sea Buckthorn Tea Set
                    shop.item[nextSlot].SetDefaults(ItemType<Items.Vanity.SeaBuckthornTea.SeaBuckthornTeaHead>());
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemType<Items.Vanity.SeaBuckthornTea.SeaBuckthornTeaBody>());
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemType<Items.Vanity.SeaBuckthornTea.SeaBuckthornTeaLegs>());
                    nextSlot++;
                    break;

                case NPCID.Cyborg:
                    if (Main.player[Main.myPlayer].ZoneJungle && Main.invasionType == 4)
                    {
                        // 50 Gold from Cyborg, during Martian Madness, in Jungle - Single Item - Grid's Set
                        shop.item[nextSlot].SetDefaults(ItemType<Items.Vanity.Grid.GridHead>());
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(ItemType<Items.Vanity.Grid.GridBody>());
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(ItemType<Items.Vanity.Grid.GridLegs>());
                        nextSlot++;
                    }
                    if (!Main.dayTime && NPC.downedMartians)
                    {
                        shop.item[nextSlot].SetDefaults(ItemType<Items.Vanity.Bounty.BountyHead>());
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(ItemType<Items.Vanity.Bounty.BountyBody>());
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(ItemType<Items.Vanity.Bounty.BountyLegs>());
                        nextSlot++;
                    }
                    if (Main.dayTime)
                    {
                        shop.item[nextSlot].SetDefaults(ItemType<Items.Vanity.CyberAngel.CyberAngelHead>());
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(ItemType<Items.Vanity.CyberAngel.CyberAngelHead1>());
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(ItemType<Items.Vanity.CyberAngel.CyberAngelBody>());
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(ItemType<Items.Vanity.CyberAngel.CyberAngelLegs>());
                        nextSlot++;
                    }
                    break;

                case NPCID.Clothier:
                    // 5 Gold from Clothier (to change to Golfer post 1.4...)
                    shop.item[nextSlot].SetDefaults(ItemType<Items.Vanity.Birdie.BirdieHead>());
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemType<Items.Vanity.Birdie.BirdieBody>());
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemType<Items.Vanity.Birdie.BirdieLegs>());
                    nextSlot++;
                    break;

                case NPCID.Pirate:
                    if (Main.raining)
                    {
                        shop.item[nextSlot].SetDefaults(ItemType<Items.Vanity.DeepDiver.DeepDiverHead>());
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(ItemType<Items.Vanity.DeepDiver.DeepDiverBody>());
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(ItemType<Items.Vanity.DeepDiver.DeepDiverLegs>());
                        nextSlot++;
                    }
                    break;

                case NPCID.Truffle:
                    shop.item[nextSlot].SetDefaults(ItemType<Items.Vanity.MushroomAlchemist.MushroomAlchemistHead>());
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemType<Items.Vanity.MushroomAlchemist.MushroomAlchemistBody>());
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemType<Items.Vanity.MushroomAlchemist.MushroomAlchemistLegs>());
                    nextSlot++;
                    break;

            }
        }

        public override void SetupTravelShop(int[] shop, ref int nextSlot)
        {
            if (Main.moonPhase == 6)
            {
                // 15 Gold from Travelling Merchant, First Quarter Moon - Single Item - Journeyman Set
                shop[nextSlot] = ItemType<Items.Vanity.Journeyman.JourneymanHead>();
                nextSlot++;
            }
            if (Main.moonPhase == 0)
            {
                // 15 Gold from Travelling Merchant, Full Moon - Single Item - Journeyman Set
                shop[nextSlot] = ItemType<Items.Vanity.Journeyman.JourneymanBody>();
                nextSlot++;
            }
            if (Main.moonPhase == 2)
            {
                // 15 Gold from Travelling Merchant, Third Quarter Moon - Single Item - Journeyman Set
                shop[nextSlot] = ItemType<Items.Vanity.Journeyman.JourneymanLegs>();
                nextSlot++;
            }

            shop[nextSlot] = ItemType<Items.Vanity.NineTailedFox.NineTailedFoxHead>();
            nextSlot++;
            shop[nextSlot] = ItemType<Items.Vanity.NineTailedFox.NineTailedFoxBody>();
            nextSlot++;
            shop[nextSlot] = ItemType<Items.Vanity.NineTailedFox.NineTailedFoxLegs>();
            nextSlot++;
            shop[nextSlot] = ItemType<Items.Vanity.NineTailedFox.NineTailedFoxAcc>();
            nextSlot++;
        }
    }
}
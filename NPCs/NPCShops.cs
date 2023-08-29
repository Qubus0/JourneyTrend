using JourneyTrend.Items.Vanity.ArcaneExosuit;
using JourneyTrend.Items.Vanity.Birdie;
using JourneyTrend.Items.Vanity.BountyHunter;
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
        public override void ModifyShop(NPCShop shop)
        {
            switch (shop.NpcType)
            {
                case NPCID.WitchDoctor:
                    // 5 Gold from Witch Doctor, during Blood Moon, in Jungle - Single Item - Arcane Exosuit Set
                    shop.Add<ArcaneExosuitHead>(Condition.InJungle, Condition.BloodMoon);
                    shop.Add<ArcaneExosuitBody>(Condition.InJungle, Condition.BloodMoon);
                    shop.Add<ArcaneExosuitLegs>(Condition.InJungle, Condition.BloodMoon);
                    break;

                case NPCID.DD2Bartender:
                    // 25 Gold from Tavernkeep - Single Item - Sea Buckthorn Tea Set
                    shop.Add<SeaBuckthornTeaHead>();
                    shop.Add<SeaBuckthornTeaBody>();
                    shop.Add<SeaBuckthornTeaLegs>();
                    break;

                case NPCID.Cyborg:
                    // 50 Gold from Cyborg, during Martian Madness, in Jungle - Single Item - Grid's Set
                    var activeMartians = new Condition("Mods.JourneyTrend.Conditions.activeMartians",
                        () => Main.invasionType == 4);
                    shop.Add<GridHead>(Condition.InJungle, activeMartians);
                    shop.Add<GridBody>(Condition.InJungle, activeMartians);
                    shop.Add<GridLegs>(Condition.InJungle, activeMartians);

                    // 5 Gold from Cyborg after Martian Madness is defeated, at night - Single Item - Bounty Hunter Set
                    shop.Add<BountyHunterHead>(Condition.TimeNight, Condition.DownedMartians);
                    shop.Add<BountyHunterBody>(Condition.TimeNight, Condition.DownedMartians);
                    shop.Add<BountyHunterLegs>(Condition.TimeNight, Condition.DownedMartians);

                    // 25 Gold from Cyborg during day time - Single Item - Cyber Angel Set
                    shop.Add<CyberAngelHead>(Condition.TimeDay);
                    shop.Add<CyberAngelBody>(Condition.TimeDay);
                    shop.Add<CyberAngelLegs>(Condition.TimeDay);
                    break;

                case NPCID.Golfer:
                    // 5 Gold from Golfer - Single Item - Birdie Set
                    shop.Add<BirdieHead>();
                    shop.Add<BirdieBody>();
                    shop.Add<BirdieLegs>();
                    break;

                case NPCID.Pirate:
                    // 10 Gold from Pirate during Rain - Single Item - Deep Diver Set
                    shop.Add<DeepDiverHead>(Condition.InRain);
                    shop.Add<DeepDiverBody>(Condition.InRain);
                    shop.Add<DeepDiverLegs>(Condition.InRain);
                    break;

                case NPCID.Truffle:
                    // 20 Gold from Truffle - Single Item - Mushroom Alchemist Set
                    shop.Add<MushroomAlchemistHead>();
                    shop.Add<MushroomAlchemistBody>();
                    shop.Add<MushroomAlchemistLegs>();
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

            // 5 Gold from Travelling Merchant - Single Item - Nine Tailed Fox Set
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
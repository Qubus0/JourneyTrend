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
                case NPCID.DD2Bartender:
                    shop.item[nextSlot].SetDefaults(mod.ItemType("SeaBuckthornTeaHead"));
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(mod.ItemType("SeaBuckthornTeaChest"));
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(mod.ItemType("SeaBuckthornTeaLegs"));
                    nextSlot++;
                    break;

                case NPCID.WitchDoctor:
                    if (Main.player[Main.myPlayer].ZoneJungle && Main.bloodMoon)
                    {
                        shop.item[nextSlot].SetDefaults(mod.ItemType("ArcaneExosuitHead"));
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(mod.ItemType("ArcaneExosuitBody"));
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(mod.ItemType("ArcaneExosuitLegs"));
                        nextSlot++;
                    }
                    break;

                case NPCID.TravellingMerchant:
                    if (Main.moonPhase == 6)
                    {
                        shop.item[nextSlot].SetDefaults(mod.ItemType("JourneymanHat"));
                        nextSlot++;
                    }
                    if (Main.moonPhase == 0)
                    {
                        shop.item[nextSlot].SetDefaults(mod.ItemType("JourneymanShirt"));
                        nextSlot++;
                    }
                    if (Main.moonPhase == 2)
                    {
                        shop.item[nextSlot].SetDefaults(mod.ItemType("JourneymanPants"));
                        nextSlot++;
                    }
                    break;

                case NPCID.Cyborg:
                    if (Main.player[Main.myPlayer].ZoneJungle && NPC.downedMoonlord && Main.invasionType == 4)  //4 -> martian madness
                    {
                        shop.item[nextSlot].SetDefaults(mod.ItemType("GridHead"));
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(mod.ItemType("GridBody"));
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(mod.ItemType("GridLegs"));
                        nextSlot++;
                    }
                    if (!Main.dayTime && NPC.downedMartians)
                    {
                        shop.item[nextSlot].SetDefaults(mod.ItemType("BountyHead"));
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(mod.ItemType("BountyBody"));
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(mod.ItemType("BountyLegs"));
                        nextSlot++;
                    }
                    break;

                case NPCID.Clothier:
                    shop.item[nextSlot].SetDefaults(mod.ItemType("BirdieHead"));
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(mod.ItemType("BirdieBody"));
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(mod.ItemType("BirdieLegs"));
                    nextSlot++;
                    break;

                case NPCID.Pirate:
                if (Main.raining)
                {
                    shop.item[nextSlot].SetDefaults(mod.ItemType("DeepDiverHead"));
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(mod.ItemType("DeepDiverBody"));
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(mod.ItemType("DeepDiverLegs"));
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
    }
}
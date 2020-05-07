using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace JourneyTrend.NPCs
{
    public class MyGlobalNPC : GlobalNPC
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
            }
        }
        public override void NPCLoot(NPC npc)
        {
            if (npc.type == NPCID.BirdBlue && Main.rand.Next(200) == 0) 
            {
                var dropChooser = new WeightedRandom<int>();
                dropChooser.Add(ModContent.ItemType<Items.Vanity.CommonKingfisher.KingfisherHead>());
                dropChooser.Add(ModContent.ItemType<Items.Vanity.CommonKingfisher.KingfisherBody>());
                dropChooser.Add(ModContent.ItemType<Items.Vanity.CommonKingfisher.KingfisherLegs>());
                int choice = dropChooser;
                Item.NewItem(npc.getRect(), choice);
            }
            if (npc.type == NPCID.Shark && Main.rand.Next(100) < 3)
            {
                var dropChooser = new WeightedRandom<int>();
                dropChooser.Add(ModContent.ItemType<Items.Vanity.SharkSet.SharkHead>());
                dropChooser.Add(ModContent.ItemType<Items.Vanity.SharkSet.SharkBody>());
                dropChooser.Add(ModContent.ItemType<Items.Vanity.SharkSet.SharkLegs>());
                int choice = dropChooser;
                Item.NewItem(npc.getRect(), choice);
            }
            if ((npc.type == NPCID.NebulaBeast || npc.type == NPCID.NebulaBrain || npc.type == NPCID.NebulaHeadcrab || npc.type == NPCID.NebulaSoldier) && Main.rand.Next(999) < 1)
            {
                var dropChooser = new WeightedRandom<int>();
                dropChooser.Add(ModContent.ItemType<Items.Vanity.CosmicTerror.CosmicTerrorHead>());
                dropChooser.Add(ModContent.ItemType<Items.Vanity.CosmicTerror.CosmicTerrorBody>());
                dropChooser.Add(ModContent.ItemType<Items.Vanity.CosmicTerror.CosmicTerrorLegs>());
                int choice = dropChooser;
                Item.NewItem(npc.getRect(), choice);
            }
            if (npc.type == NPCID.PossessedArmor && Main.rand.Next(200) < 1)
            {
                Item.NewItem(npc.getRect(), mod.ItemType("IronCoreHead"));
                Item.NewItem(npc.getRect(), mod.ItemType("IronCoreBody"));
                Item.NewItem(npc.getRect(), mod.ItemType("IronCoreLegs"));
            }
        }
    }
}
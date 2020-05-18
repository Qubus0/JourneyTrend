using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace JourneyTrend.NPCs
{
    class NPCLoots : GlobalNPC
    {
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
            if (npc.type == NPCID.DukeFishron && !Main.expertMode && Main.rand.Next(10) < 1)
            {
                Item.NewItem(npc.getRect(), mod.ItemType("MagicGrillHead"));
                Item.NewItem(npc.getRect(), mod.ItemType("MagicGrillBody"));
                Item.NewItem(npc.getRect(), mod.ItemType("MagicGrillLegs"));
            }
            if (npc.type == NPCID.Mothron && Main.rand.Next(25) < 3)
            {
                Item.NewItem(npc.getRect(), mod.ItemType("MothronMask"));
                Item.NewItem(npc.getRect(), mod.ItemType("MothronShirt"));
                Item.NewItem(npc.getRect(), mod.ItemType("MothronPants"));
            }
            if ((npc.type == NPCID.GreekSkeleton || npc.type == NPCID.Medusa) && Main.rand.Next(15) == 0)
            {
                Item.NewItem(npc.getRect(), mod.ItemType("RookieBase"));
                Item.NewItem(npc.getRect(), mod.ItemType("RookieBody"));
                Item.NewItem(npc.getRect(), mod.ItemType("RookieHead"));
            }
            if ((npc.type == NPCID.GraniteGolem || npc.type == NPCID.GraniteFlyer) && Main.rand.Next(15) == 0)
            {
                Item.NewItem(npc.getRect(), mod.ItemType("RookieBase"));
                Item.NewItem(npc.getRect(), mod.ItemType("RookieBody"));
                Item.NewItem(npc.getRect(), mod.ItemType("RookieHead"));
                Item.NewItem(npc.getRect(), ItemID.ReflectiveMetalDye, 3);
            }
        }
    }
}
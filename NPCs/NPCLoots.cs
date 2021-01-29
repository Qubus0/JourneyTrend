using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;
using static Terraria.ModLoader.ModContent;


namespace JourneyTrend.NPCs
{
    class NPCLoots : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (npc.type == NPCID.BirdBlue && Main.rand.Next(200) == 0)
            {
                // 1 in 200 from Blue Jay's - Single Item - Common Kingfisher Set
                var dropChooser = new WeightedRandom<int>();
                dropChooser.Add(ItemType<Items.Vanity.Kingfisher.KingfisherHead>());
                dropChooser.Add(ItemType<Items.Vanity.Kingfisher.KingfisherBody>());
                dropChooser.Add(ItemType<Items.Vanity.Kingfisher.KingfisherLegs>());
                int choice = dropChooser;
                Item.NewItem(npc.getRect(), choice);
            }

            if (npc.type == NPCID.Shark && Main.rand.Next(100) < 3)
            {
                // 3 in 100 from Shark - Single Item - Shark Set
                var dropChooser = new WeightedRandom<int>();
                dropChooser.Add(ItemType<Items.Vanity.Shark.SharkHead>());
                dropChooser.Add(ItemType<Items.Vanity.Shark.SharkBody>());
                dropChooser.Add(ItemType<Items.Vanity.Shark.SharkLegs>());
                int choice = dropChooser;
                Item.NewItem(npc.getRect(), choice);
            }

            if ((npc.type == NPCID.NebulaBeast || npc.type == NPCID.NebulaBrain || npc.type == NPCID.NebulaHeadcrab || npc.type == NPCID.NebulaSoldier) && Main.rand.Next(999) < 1)
            {
                // 1 in 999 from Nebula Enemies - Single Item - Cosmic Terror Set
                var dropChooser = new WeightedRandom<int>();
                dropChooser.Add(ItemType<Items.Vanity.CosmicTerror.CosmicTerrorHead>());
                dropChooser.Add(ItemType<Items.Vanity.CosmicTerror.CosmicTerrorBody>());
                dropChooser.Add(ItemType<Items.Vanity.CosmicTerror.CosmicTerrorLegs>());
                int choice = dropChooser;
                Item.NewItem(npc.getRect(), choice);
            }

            if (npc.type == NPCID.Mothron && Main.rand.Next(25) < 3 && NPC.downedPlantBoss)
            {
                // 3 in 25 from Mothron - Full Set (With Vanilla Wings) - Mothron Set
                Item.NewItem(npc.getRect(), ItemType<Items.Vanity.Mothron.MothronHead>());
                Item.NewItem(npc.getRect(), ItemType<Items.Vanity.Mothron.MothronBody>());
                Item.NewItem(npc.getRect(), ItemType<Items.Vanity.Mothron.MothronLegs>());
                Item.NewItem(npc.getRect(), ItemID.MothronWings);
            }

            if (npc.type == NPCID.PossessedArmor && Main.rand.Next(200) < 1)
            {
                // 1 in 200 from Possessed Armor - Full Set - Knight of the Iron Core Set
                Item.NewItem(npc.getRect(), ItemType<Items.Vanity.IronCore.IronCoreHead>());
                Item.NewItem(npc.getRect(), ItemType<Items.Vanity.IronCore.IronCoreBody>());
                Item.NewItem(npc.getRect(), ItemType<Items.Vanity.IronCore.IronCoreLegs>());
            }

            if (npc.type == NPCID.DukeFishron && !Main.expertMode && Main.rand.Next(10) < 1)
            {
                // 1 in 10 from Duke Fishron - Full Set - Magic Grill Megashark Set
                Item.NewItem(npc.getRect(), ItemType<Items.Vanity.MagicGrill.MagicGrillHead>());
                Item.NewItem(npc.getRect(), ItemType<Items.Vanity.MagicGrill.MagicGrillBody>());
                Item.NewItem(npc.getRect(), ItemType<Items.Vanity.MagicGrill.MagicGrillLegs>());
            }

            if ((npc.type == NPCID.GreekSkeleton || npc.type == NPCID.Medusa || npc.type == NPCID.GraniteGolem || npc.type == NPCID.GraniteFlyer) && Main.rand.Next(15) == 0)
            {
                // 1 in 15 from Granite and Marble Enemies - Full Set - Rookie Set
                Item.NewItem(npc.getRect(), ItemType<Items.Vanity.Rookie.RookieHead>());
                Item.NewItem(npc.getRect(), ItemType<Items.Vanity.Rookie.RookieBody>());
                Item.NewItem(npc.getRect(), ItemType<Items.Vanity.Rookie.RookieLegs>());
                if ((npc.type == NPCID.GraniteGolem || npc.type == NPCID.GraniteFlyer))
                {
                    // If Granite Enemies only, drop 3 Reflective Metal Dye as well
                    Item.NewItem(npc.getRect(), ItemID.ReflectiveMetalDye, 3);
                }
            }

            if (npc.type == NPCID.WyvernHead && !Main.dayTime && !Main.LocalPlayer.ZoneHoly && Main.rand.Next(5) == 0)
            {
                // 1 in 5 from Wyvern, Night Time, Not in Hallow - Single - Kuijia Set
                Item.NewItem(npc.getRect(), ItemType<Items.Vanity.Kuijia.KuijiaHead>());
            }

            if (npc.type == NPCID.WyvernHead && !Main.dayTime && Main.LocalPlayer.ZoneHoly && Main.rand.Next(2) == 0)
            {
                // 1 in 2 from Wyvern, Night Time, in Hallow - Single - Kuijia Set
                var dropChooser = new WeightedRandom<int>();
                dropChooser.Add(ItemType<Items.Vanity.Kuijia.KuijiaBody>());
                dropChooser.Add(ItemType<Items.Vanity.Kuijia.KuijiaLegs>());
                int choice = dropChooser;
                Item.NewItem(npc.getRect(), choice);
            }

            if ((npc.type == NPCID.WyvernHead && Main.rand.Next(20) == 0) || (npc.type == NPCID.Harpy && Main.rand.Next(100) == 0))
            {
                // 1 in 20 (5%) from Wyvern - Full Set (Bag) - Storm Conqueror Set
                // 1 in 100 (1%) from Harpy - Full Set (Bag) - Storm Conqueror Set
                // (1 in 400 (0.25%) from Anything, in Space - Full Set (Bag) - Storm Conqueror Set) Not possible - too many bugs with other mods
                Item.NewItem(npc.getRect(), ItemType<Items.Vanity.StormConqueror.StormConquerorBag>());
            }

            if (npc.type == NPCID.Mothron && Main.rand.Next(5) == 0)
            {
                var dropChooser = new WeightedRandom<int>();
                dropChooser.Add(ItemType<Items.Vanity.BrokenHero.BrokenHeroHead>());
                dropChooser.Add(ItemType<Items.Vanity.BrokenHero.BrokenHeroBody>());
                dropChooser.Add(ItemType<Items.Vanity.BrokenHero.BrokenHeroLegs>());
                int choice = dropChooser;
                Item.NewItem(npc.getRect(), choice);
            }

            if (npc.type == NPCID.Mothron && Main.rand.Next(20) == 1)
            {
                Item.NewItem(npc.getRect(), ItemType<Items.Vanity.Terra.TerraHead>());
                Item.NewItem(npc.getRect(), ItemType<Items.Vanity.Terra.TerraBody>());
                Item.NewItem(npc.getRect(), ItemType<Items.Vanity.Terra.TerraLegs>());
            }

            if ((npc.type == NPCID.Eyezor || npc.type == NPCID.Nailhead || npc.type == NPCID.Reaper) && Main.rand.Next(40) == 1)
            {
                Item.NewItem(npc.getRect(), ItemType<Items.Vanity.Terra.TerraHead>());
                Item.NewItem(npc.getRect(), ItemType<Items.Vanity.Terra.TerraBody>());
                Item.NewItem(npc.getRect(), ItemType<Items.Vanity.Terra.TerraLegs>());
            }

            if ((npc.type == NPCID.MossHornet || npc.type == NPCID.Moth || npc.type == NPCID.WallCreeperWall || npc.type == NPCID.WallCreeper) && Main.rand.Next(200) == 0)
            {
                Item.NewItem(npc.getRect(), ItemType<Items.Vanity.SwampHorror.SwampHorrorHead>());
                Item.NewItem(npc.getRect(), ItemType<Items.Vanity.SwampHorror.SwampHorrorBody>());
                Item.NewItem(npc.getRect(), ItemType<Items.Vanity.SwampHorror.SwampHorrorLegs>());
            }

            if (npc.type == NPCID.DD2Bartender && Main.rand.Next(4) == 0)
            {
                Item.NewItem(npc.getRect(), ItemType<Items.Vanity.Shootsaton.ShootsatonBag>());
            }

            if (npc.type == NPCID.WyvernHead && Main.rand.Next(3) == 0)
            {
                if (Main.rand.Next(2) == 0)
                {
                    Item.NewItem(npc.getRect(), ItemType<Items.Vanity.Pilot.PilotHead>());
                } else {
                    Item.NewItem(npc.getRect(), ItemType<Items.Vanity.Pilot.PilotBody>());
                }
            }

            for (int i = 3; i < 9; i++)     //loops through armor slots 3 to 9 (non vanity accessories)
            {
                if (Main.LocalPlayer.armor[i].type == ItemID.HermesBoots)   //if one is hermes boots
                {
                    if (npc.type == NPCID.DukeFishron && Main.rand.Next(3) == 0)
                    {
                        Item.NewItem(npc.getRect(), ItemType<Items.Vanity.AndromedaPilot.AndromedaPilotHead>());
                        Item.NewItem(npc.getRect(), ItemType<Items.Vanity.AndromedaPilot.AndromedaPilotBody>());
                        Item.NewItem(npc.getRect(), ItemType<Items.Vanity.AndromedaPilot.AndromedaPilotLegs>());
                    }
                }
            }

            if ((npc.type == NPCID.UndeadViking || npc.type == NPCID.ArmoredViking) && Main.rand.Next(20) == 0)
            {
                Item.NewItem(npc.getRect(), ItemType<Items.Vanity.Draugr.DraugrHead>());
                Item.NewItem(npc.getRect(), ItemType<Items.Vanity.Draugr.DraugrBody>());
                Item.NewItem(npc.getRect(), ItemType<Items.Vanity.Draugr.DraugrLegs>());
            }

            if ((npc.type == NPCID.BigMimicCorruption || npc.type == NPCID.BigMimicCrimson) && Main.rand.Next(20) == 0)
            {
                Item.NewItem(npc.getRect(), ItemType<Items.Vanity.WitchsVoid.WitchsVoidBag>());
            }

            if ((npc.type == NPCID.Clinger || npc.type == NPCID.SeekerHead) && Main.rand.Next(80) == 0)
            {
                Item.NewItem(npc.getRect(), ItemType<Items.Vanity.ShadowFiend.ShadowFiendHead>());
                Item.NewItem(npc.getRect(), ItemType<Items.Vanity.ShadowFiend.ShadowFiendBody>());
                Item.NewItem(npc.getRect(), ItemType<Items.Vanity.ShadowFiend.ShadowFiendLegs>());
            }

            if ((npc.type == NPCID.IchorSticker) && Main.rand.Next(60) == 0)
            {
                Item.NewItem(npc.getRect(), ItemType<Items.Vanity.ShadowFiend.ShadowFiendHead1>());
                Item.NewItem(npc.getRect(), ItemType<Items.Vanity.ShadowFiend.ShadowFiendBody1>());
                Item.NewItem(npc.getRect(), ItemType<Items.Vanity.ShadowFiend.ShadowFiendLegs1>());
            }

            if ((npc.type == NPCID.GoblinSummoner) && Main.rand.Next(75) == 0)
            {
                Item.NewItem(npc.getRect(), ItemType<Items.Vanity.ShadowSpell.ShadowSpellHead>());
                Item.NewItem(npc.getRect(), ItemType<Items.Vanity.ShadowSpell.ShadowSpellBody>());
                Item.NewItem(npc.getRect(), ItemType<Items.Vanity.ShadowSpell.ShadowSpellLegs>());
            }

            if (((npc.type == NPCID.Paladin) && Main.rand.Next(50) < 3) || ((npc.type == NPCID.BlueArmoredBones) && Main.rand.Next(100) == 0))
            {
                Item.NewItem(npc.getRect(), ItemType<Items.Vanity.KnightOfJudgement.KnightOfJudgementHead>());
                Item.NewItem(npc.getRect(), ItemType<Items.Vanity.KnightOfJudgement.KnightOfJudgementBody>());
                Item.NewItem(npc.getRect(), ItemType<Items.Vanity.KnightOfJudgement.KnightOfJudgementLegs>());
            }
        }
    }
}
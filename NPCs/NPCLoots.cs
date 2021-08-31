using JourneyTrend.Items.Vanity.AndromedaPilot;
using JourneyTrend.Items.Vanity.BrokenHero;
using JourneyTrend.Items.Vanity.CosmicTerror;
using JourneyTrend.Items.Vanity.Draugr;
using JourneyTrend.Items.Vanity.IronCore;
using JourneyTrend.Items.Vanity.Kingfisher;
using JourneyTrend.Items.Vanity.KnightOfJudgement;
using JourneyTrend.Items.Vanity.Kuijia;
using JourneyTrend.Items.Vanity.MagicGrill;
using JourneyTrend.Items.Vanity.Mothron;
using JourneyTrend.Items.Vanity.Pilot;
using JourneyTrend.Items.Vanity.Rookie;
using JourneyTrend.Items.Vanity.ShadowFiend;
using JourneyTrend.Items.Vanity.ShadowSpell;
using JourneyTrend.Items.Vanity.Shark;
using JourneyTrend.Items.Vanity.Shootsaton;
using JourneyTrend.Items.Vanity.StormConqueror;
using JourneyTrend.Items.Vanity.SwampHorror;
using JourneyTrend.Items.Vanity.Terra;
using JourneyTrend.Items.Vanity.WitchsVoid;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;
using static Terraria.ModLoader.ModContent;


namespace JourneyTrend.NPCs
{
    internal class NpcLoots : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if (npc.type == NPCID.BirdBlue && Main.rand.Next(200) == 0)
            {
                // 1 in 200 from Blue Jay's - Single Item - Common Kingfisher Set
                var dropChooser = new WeightedRandom<int>();
                dropChooser.Add(ItemType<KingfisherHead>());
                dropChooser.Add(ItemType<KingfisherBody>());
                dropChooser.Add(ItemType<KingfisherLegs>());
                int choice = dropChooser;
                Item.NewItem(npc.getRect(), choice);
            }

            if (npc.type == NPCID.Shark && Main.rand.Next(100) < 3)
            {
                // 3 in 100 from Shark - Single Item - Shark Set
                var dropChooser = new WeightedRandom<int>();
                dropChooser.Add(ItemType<SharkHead>());
                dropChooser.Add(ItemType<SharkBody>());
                dropChooser.Add(ItemType<SharkLegs>());
                int choice = dropChooser;
                Item.NewItem(npc.getRect(), choice);
            }

            if ((npc.type == NPCID.MoonLordCore ||
                 npc.type == NPCID.NebulaBeast ||
                 npc.type == NPCID.NebulaBrain ||
                 npc.type == NPCID.NebulaHeadcrab ||
                 npc.type == NPCID.NebulaSoldier ||
                 npc.type == NPCID.StardustWormHead ||
                 npc.type == NPCID.StardustCellBig ||
                 npc.type == NPCID.StardustJellyfishBig ||
                 npc.type == NPCID.StardustSpiderBig ||
                 npc.type == NPCID.StardustSoldier ||
                 npc.type == NPCID.SolarCrawltipedeHead ||
                 npc.type == NPCID.SolarDrakomire ||
                 npc.type == NPCID.SolarDrakomireRider ||
                 npc.type == NPCID.SolarSpearman ||
                 npc.type == NPCID.SolarSroller ||
                 npc.type == NPCID.SolarCorite ||
                 npc.type == NPCID.SolarSolenian ||
                 npc.type == NPCID.VortexRifleman ||
                 npc.type == NPCID.VortexHornetQueen ||
                 npc.type == NPCID.VortexSoldier) && Main.rand.Next(999) < 1)
            {
                // 1 in 999 from Nebula Enemies - Single Item - Cosmic Terror Set
                var dropChooser = new WeightedRandom<int>();
                dropChooser.Add(ItemType<CosmicTerrorHead>());
                dropChooser.Add(ItemType<CosmicTerrorBody>());
                dropChooser.Add(ItemType<CosmicTerrorLegs>());
                int choice = dropChooser;
                Item.NewItem(npc.getRect(), choice);
            }

            if (npc.type == NPCID.Mothron && Main.rand.Next(25) < 3 && NPC.downedPlantBoss)
            {
                // 3 in 25 from Mothron - Full Set (With Vanilla Wings) - Mothron Set
                Item.NewItem(npc.getRect(), ItemType<MothronHead>());
                Item.NewItem(npc.getRect(), ItemType<MothronBody>());
                Item.NewItem(npc.getRect(), ItemType<MothronLegs>());
                Item.NewItem(npc.getRect(), ItemID.MothronWings);
            }

            if (npc.type == NPCID.PossessedArmor && Main.rand.Next(200) < 1)
            {
                // 1 in 200 from Possessed Armor - Full Set - Knight of the Iron Core Set
                Item.NewItem(npc.getRect(), ItemType<IronCoreHead>());
                Item.NewItem(npc.getRect(), ItemType<IronCoreBody>());
                Item.NewItem(npc.getRect(), ItemType<IronCoreLegs>());
            }

            if (npc.type == NPCID.DukeFishron && !Main.expertMode && Main.rand.Next(10) < 1)
            {
                // 1 in 10 from Duke Fishron - Full Set - Magic Grill Megashark Set
                Item.NewItem(npc.getRect(), ItemType<MagicGrillHead>());
                Item.NewItem(npc.getRect(), ItemType<MagicGrillBody>());
                Item.NewItem(npc.getRect(), ItemType<MagicGrillLegs>());
            }

            if ((npc.type == NPCID.GreekSkeleton || npc.type == NPCID.Medusa || npc.type == NPCID.GraniteGolem ||
                 npc.type == NPCID.GraniteFlyer) && Main.rand.Next(15) == 0)
            {
                // 1 in 15 from Granite and Marble Enemies - Full Set - Rookie Set
                Item.NewItem(npc.getRect(), ItemType<RookieHead>());
                Item.NewItem(npc.getRect(), ItemType<RookieBody>());
                Item.NewItem(npc.getRect(), ItemType<RookieLegs>());
                if (npc.type == NPCID.GraniteGolem || npc.type == NPCID.GraniteFlyer)
                    // If Granite Enemies only, drop 3 Reflective Metal Dye as well
                    Item.NewItem(npc.getRect(), ItemID.ReflectiveMetalDye, 3);
            }

            if (npc.type == NPCID.WyvernHead && !Main.dayTime && !Main.LocalPlayer.ZoneHallow && Main.rand.Next(5) == 0)
                // 1 in 5 from Wyvern, Night Time, Not in Hallow - Single - Kuijia Set
                Item.NewItem(npc.getRect(), ItemType<KuijiaHead>());

            if (npc.type == NPCID.WyvernHead && !Main.dayTime && Main.LocalPlayer.ZoneHallow && Main.rand.Next(2) == 0)
            {
                // 1 in 2 from Wyvern, Night Time, in Hallow - Single - Kuijia Set
                var dropChooser = new WeightedRandom<int>();
                dropChooser.Add(ItemType<KuijiaBody>());
                dropChooser.Add(ItemType<KuijiaLegs>());
                int choice = dropChooser;
                Item.NewItem(npc.getRect(), choice);
            }

            if (npc.type == NPCID.WyvernHead && Main.rand.Next(20) == 0 ||
                npc.type == NPCID.Harpy && Main.rand.Next(100) == 0)
                // 1 in 20 (5%) from Wyvern - Full Set (Bag) - Storm Conqueror Set
                // 1 in 100 (1%) from Harpy - Full Set (Bag) - Storm Conqueror Set
                // (1 in 400 (0.25%) from Anything, in Space - Full Set (Bag) - Storm Conqueror Set) Not possible - too many bugs with other mods
                Item.NewItem(npc.getRect(), ItemType<StormConquerorBag>());

            if (npc.type == NPCID.Mothron && Main.rand.Next(5) == 0)
            {
                var dropChooser = new WeightedRandom<int>();
                dropChooser.Add(ItemType<BrokenHeroHead>());
                dropChooser.Add(ItemType<BrokenHeroBody>());
                dropChooser.Add(ItemType<BrokenHeroLegs>());
                int choice = dropChooser;
                Item.NewItem(npc.getRect(), choice);
            }

            if (npc.type == NPCID.Mothron && Main.rand.Next(20) == 1 ||
                (npc.type == NPCID.Eyezor || npc.type == NPCID.Nailhead || npc.type == NPCID.Reaper) &&
                Main.rand.Next(40) == 1)
            {
                Item.NewItem(npc.getRect(), ItemType<TerraHead>());
                Item.NewItem(npc.getRect(), ItemType<TerraBody>());
                Item.NewItem(npc.getRect(), ItemType<TerraLegs>());
            }

            if ((npc.type == NPCID.MossHornet || npc.type == NPCID.Moth || npc.type == NPCID.WallCreeperWall ||
                 npc.type == NPCID.WallCreeper) && Main.rand.Next(200) == 0)
            {
                Item.NewItem(npc.getRect(), ItemType<SwampHorrorHead>());
                Item.NewItem(npc.getRect(), ItemType<SwampHorrorBody>());
                Item.NewItem(npc.getRect(), ItemType<SwampHorrorLegs>());
            }

            if (npc.type == NPCID.DD2Bartender && Main.rand.Next(4) == 0)
                Item.NewItem(npc.getRect(), ItemType<ShootsatonBag>());

            if (npc.type == NPCID.WyvernHead && Main.rand.Next(3) == 0)
            {
                var dropChooser = new WeightedRandom<int>();
                dropChooser.Add(ItemType<PilotHead>());
                dropChooser.Add(ItemType<PilotBody>());
                int choice = dropChooser;
                Item.NewItem(npc.getRect(), choice);
            }

            for (var i = 3; i < 9; i++) //loops through armor slots 3 to 9 (non vanity accessories)
                if (Main.LocalPlayer.armor[i].type == ItemID.HermesBoots) //if one is hermes boots
                    if (npc.type == NPCID.DukeFishron && Main.rand.Next(3) == 0)
                    {
                        Item.NewItem(npc.getRect(), ItemType<AndromedaPilotHead>());
                        Item.NewItem(npc.getRect(), ItemType<AndromedaPilotBody>());
                        Item.NewItem(npc.getRect(), ItemType<AndromedaPilotLegs>());
                    }

            if ((npc.type == NPCID.UndeadViking || npc.type == NPCID.ArmoredViking) && Main.rand.Next(20) == 0)
            {
                Item.NewItem(npc.getRect(), ItemType<DraugrHead>());
                Item.NewItem(npc.getRect(), ItemType<DraugrBody>());
                Item.NewItem(npc.getRect(), ItemType<DraugrLegs>());
            }

            if ((npc.type == NPCID.BigMimicCorruption || npc.type == NPCID.BigMimicCrimson) && Main.rand.Next(20) == 0)
                Item.NewItem(npc.getRect(), ItemType<WitchsVoidBag>());

            if ((npc.type == NPCID.Clinger || npc.type == NPCID.SeekerHead) && Main.rand.Next(80) == 0)
            {
                Item.NewItem(npc.getRect(), ItemType<ShadowFiendHead>());
                Item.NewItem(npc.getRect(), ItemType<ShadowFiendBody>());
                Item.NewItem(npc.getRect(), ItemType<ShadowFiendLegs>());
            }

            if (npc.type == NPCID.IchorSticker && Main.rand.Next(60) == 0)
            {
                Item.NewItem(npc.getRect(), ItemType<ShadowFiendHead1>());
                Item.NewItem(npc.getRect(), ItemType<ShadowFiendBody1>());
                Item.NewItem(npc.getRect(), ItemType<ShadowFiendLegs1>());
            }

            if (npc.type == NPCID.GoblinSummoner && Main.rand.Next(75) == 0)
            {
                Item.NewItem(npc.getRect(), ItemType<ShadowSpellHead>());
                Item.NewItem(npc.getRect(), ItemType<ShadowSpellBody>());
                Item.NewItem(npc.getRect(), ItemType<ShadowSpellLegs>());
            }

            if (npc.type == NPCID.Paladin && Main.rand.Next(50) < 3 ||
                npc.type == NPCID.BlueArmoredBones && Main.rand.Next(100) == 0)
            {
                Item.NewItem(npc.getRect(), ItemType<KnightOfJudgementHead>());
                Item.NewItem(npc.getRect(), ItemType<KnightOfJudgementBody>());
                Item.NewItem(npc.getRect(), ItemType<KnightOfJudgementLegs>());
            }
        }
    }
}
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
using JourneyTrend.World.ItemDropRules.DropConditions;
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;


namespace JourneyTrend.NPCs
{
    internal class NpcLoots : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            switch (npc.type)
            {
                case NPCID.BirdBlue: // tested
                    // 1/50 from Blue Jays - Single Item - Common Kingfisher Set // tested
                    npcLoot.Add(
                        ItemDropRule.OneFromOptions(
                            50, 
                            ItemType<KingfisherHead>(),
                            ItemType<KingfisherBody>(),
                            ItemType<KingfisherLegs>()
                        )
                    );
                    break;
                case NPCID.Shark: // tested
                    // 1/33 from Shark - Single Item - Shark Set
                    npcLoot.Add(
                        ItemDropRule.OneFromOptions(
                            33,
                            ItemType<SharkHead>(),
                            ItemType<SharkBody>(),
                            ItemType<SharkLegs>()
                        )
                    );
                    break;
                case NPCID.MoonLordCore:
                case NPCID.NebulaBeast:
                case NPCID.NebulaBrain:
                case NPCID.NebulaHeadcrab:
                case NPCID.NebulaSoldier:
                case NPCID.StardustWormHead:
                case NPCID.StardustCellBig:
                case NPCID.StardustJellyfishBig:
                case NPCID.StardustSpiderBig:
                case NPCID.StardustSoldier:
                case NPCID.SolarCrawltipedeHead:
                case NPCID.SolarDrakomire:
                case NPCID.SolarDrakomireRider:
                case NPCID.SolarSpearman:
                case NPCID.SolarSroller:
                case NPCID.SolarCorite:
                case NPCID.SolarSolenian:
                case NPCID.VortexRifleman:
                case NPCID.VortexHornetQueen:
                case NPCID.VortexSoldier:
                    // 1/666 from Pillar Enemies and MoonLord - Single Item - Cosmic Terror Set // tested
                    npcLoot.Add(
                        ItemDropRule.OneFromOptions(
                            666,
                            ItemType<CosmicTerrorHead>(),
                            ItemType<CosmicTerrorBody>(),
                            ItemType<CosmicTerrorLegs>()
                        )
                    );
                    break;
                case NPCID.Mothron:
                {
                    // 1/8 from Mothron, after Plantera - Full Set (+ Vanilla Wings) - Mothron Set // tested
                    var planteraCondition = new LeadingConditionRule(new Conditions.DownedPlantera());
                
                    var armorSetRule = ItemDropRule.Common(ItemType<MothronHead>(), 8);
                    armorSetRule.OnSuccess(ItemDropRule.Common(ItemType<MothronBody>()));
                    armorSetRule.OnSuccess(ItemDropRule.Common(ItemType<MothronLegs>()));
                    armorSetRule.OnSuccess(ItemDropRule.Common(ItemID.MothronWings));
                    planteraCondition.OnSuccess(armorSetRule);
                    npcLoot.Add(planteraCondition);
                    
                    // 1/5 from Mothron - Single - Broken Hero Set // tested
                    npcLoot.Add(
                        ItemDropRule.OneFromOptions(
                            5, 
                            ItemType<BrokenHeroHead>(),
                            ItemType<BrokenHeroBody>(),
                            ItemType<BrokenHeroLegs>()
                        )
                    );

                    // 1/20 from Mothron - Full Set - Terra Set // tested
                    armorSetRule = ItemDropRule.Common(ItemType<TerraHead>(), 20);
                    armorSetRule.OnSuccess(ItemDropRule.Common(ItemType<TerraBody>()));
                    armorSetRule.OnSuccess(ItemDropRule.Common(ItemType<TerraLegs>()));
                    npcLoot.Add(armorSetRule);
                    break;
                }
                case NPCID.Eyezor:
                case NPCID.Nailhead:
                case NPCID.Reaper:
                {
                    // 1/40 from Eclipse Enemies - Full Set - Terra Set // tested
                    var armorSetRule = ItemDropRule.Common(ItemType<TerraHead>(), 40);
                    armorSetRule.OnSuccess(ItemDropRule.Common(ItemType<TerraBody>()));
                    armorSetRule.OnSuccess(ItemDropRule.Common(ItemType<TerraLegs>()));
                    npcLoot.Add(armorSetRule);
                    break;
                }
                case NPCID.PossessedArmor:
                {
                    // 1/200 from Possessed Armor - Full Set - Knight of the Iron Core Set // tested
                    var armorSetRule = ItemDropRule.Common(ItemType<IronCoreHead>(), 200);
                    armorSetRule.OnSuccess(ItemDropRule.Common(ItemType<IronCoreBody>()));
                    armorSetRule.OnSuccess(ItemDropRule.Common(ItemType<IronCoreLegs>()));
                    npcLoot.Add(armorSetRule);
                    break;
                }
                case NPCID.Medusa:
                {
                    // always from Medusa when wearing Hermes boots - Head and Body - Andromeda Pilot Set // tested
                    var wearingHermesBootsCondition = new LeadingConditionRule(new PlayerWearingHermesBootsDropCondition());
                
                    var armorSetRule = ItemDropRule.Common(ItemType<AndromedaPilotHead>());
                    armorSetRule.OnSuccess(ItemDropRule.Common(ItemType<AndromedaPilotBody>()));
                    wearingHermesBootsCondition.OnSuccess(armorSetRule);
                    npcLoot.Add(wearingHermesBootsCondition);
                    
                    goto case NPCID.GreekSkeleton; // tested (Rookie also drops from Medusa)
                }
                case NPCID.GreekSkeleton:
                case NPCID.GraniteGolem:
                case NPCID.GraniteFlyer:
                {
                    // 1/15 from Granite and Marble Enemies - Full Set - Rookie Set // tested
                    var armorSetRule = ItemDropRule.Common(ItemType<RookieHead>(), 15);
                    armorSetRule.OnSuccess(ItemDropRule.Common(ItemType<RookieBody>()));
                    armorSetRule.OnSuccess(ItemDropRule.Common(ItemType<RookieLegs>()));

                    if (npc.type == NPCID.GraniteGolem || npc.type == NPCID.GraniteFlyer)
                        // Granite Enemies only, drop 3 Reflective Metal Dye as well // tested
                        armorSetRule.OnSuccess(new CommonDrop(ItemID.ReflectiveMetalDye, 1, 3, 3));

                    npcLoot.Add(armorSetRule);
                    break;
                }
                case NPCID.WyvernHead:
                {
                    // 1/5 from Wyvern, Night Time, Not in Hallow - Head - Kuijia Set // tested
                    var notHallowNight = new LeadingConditionRule(new NotZoneHallowNightDropCondition());
                    notHallowNight.OnSuccess(ItemDropRule.Common(ItemType<KuijiaHead>(), 5));
                    npcLoot.Add(notHallowNight);

                    // 1/2 from Wyvern, Night Time, in Hallow - Single Body, Legs - Kuijia Set // tested
                    var hallowNight = new LeadingConditionRule(new ZoneHallowNightDropCondition());
                    hallowNight.OnSuccess(ItemDropRule.OneFromOptions(2, ItemType<KuijiaBody>(), ItemType<KuijiaLegs>()));
                    npcLoot.Add(hallowNight);

                    // 1/20 from Wyvern - Full Set (Bag) - Storm Conqueror Set // tested
                    npcLoot.Add(ItemDropRule.Common(ItemType<StormConquerorBag>(), 20));

                    // 1/3 from Wyvern - Single Item - Pilot Set // tested
                    npcLoot.Add(
                        ItemDropRule.OneFromOptions(
                            3,
                            ItemType<PilotHead>(),
                            ItemType<PilotBody>()
                        )
                    );
                    break;
                }
                case NPCID.Harpy:
                    // 1/100 from Harpy - Full Set (Bag) - Storm Conqueror Set // tested
                    npcLoot.Add(ItemDropRule.Common(ItemType<StormConquerorBag>(), 100));
                    break;
                case NPCID.GiantMossHornet:
                case NPCID.BigMossHornet:
                case NPCID.MossHornet:
                case NPCID.LittleMossHornet:
                case NPCID.TinyMossHornet:
                case NPCID.Moth:
                case NPCID.WallCreeperWall:
                case NPCID.WallCreeper:
                {
                    // 1/200 from Jungle Enemies - Full Set - Swamp Horror Set // tested
                    var armorSetRule = ItemDropRule.Common(ItemType<SwampHorrorHead>(), 200);
                    armorSetRule.OnSuccess(ItemDropRule.Common(ItemType<SwampHorrorBody>()));
                    armorSetRule.OnSuccess(ItemDropRule.Common(ItemType<SwampHorrorLegs>()));
                    npcLoot.Add(armorSetRule);
                    break;
                }
                case NPCID.DD2Bartender:
                    // 1/4 from Tavernkeep - Full Set (Bag) - Shootsaton Set // tested
                    npcLoot.Add(ItemDropRule.Common(ItemType<ShootsatonBag>(), 4));
                    break;
                case NPCID.DukeFishron:
                {
                    // 1/3 from Duke Fishron - Legs - Andromeda Pilot Set // tested 
                    npcLoot.Add(ItemDropRule.Common(ItemType<AndromedaPilotLegs>(), 3));
                    
                    // 1/10 from Duke Fishron - Full Set - Magic Grill Megashark Set (expert included in boss bag) // tested
                    var notExpertCondition = new LeadingConditionRule(new Conditions.NotExpert());
                
                    var armorSetRule = ItemDropRule.Common(ItemType<MagicGrillHead>(), 10);
                    armorSetRule.OnSuccess(ItemDropRule.Common(ItemType<MagicGrillBody>()));
                    armorSetRule.OnSuccess(ItemDropRule.Common(ItemType<MagicGrillLegs>()));
                    notExpertCondition.OnSuccess(armorSetRule);
                    npcLoot.Add(notExpertCondition);
                    break;
                }
                case NPCID.UndeadViking:
                case NPCID.ArmoredViking:
                {
                    // 1/20 from Duke Vikings - Full Set - Draugr Set // tested
                    var armorSetRule = ItemDropRule.Common(ItemType<DraugrHead>(), 20);
                    armorSetRule.OnSuccess(ItemDropRule.Common(ItemType<DraugrBody>()));
                    armorSetRule.OnSuccess(ItemDropRule.Common(ItemType<DraugrLegs>()));
                    npcLoot.Add(armorSetRule);
                    break;
                }
                case NPCID.BigMimicCorruption:
                case NPCID.BigMimicCrimson:
                    // 1/10 from Big Evil Mimics - Full Set (Bag) - Witchs Void Set // tested
                    npcLoot.Add(ItemDropRule.Common(ItemType<WitchsVoidBag>(), 10));
                    break;
                case NPCID.Clinger:
                case NPCID.SeekerHead:
                {
                    // 1/80 from Hardmode Corruption Enemies - Full Set - Shadow Fiend Set // tested
                    var armorSetRule = ItemDropRule.Common(ItemType<ShadowFiendHead>(), 80);
                    armorSetRule.OnSuccess(ItemDropRule.Common(ItemType<ShadowFiendBody>()));
                    armorSetRule.OnSuccess(ItemDropRule.Common(ItemType<ShadowFiendLegs>()));
                    npcLoot.Add(armorSetRule);
                    break;
                }
                case NPCID.IchorSticker:
                {
                    // 1/60 from Hardmode Crimson Enemies - Full Set - Shadow Fiend Set (alt) // tested
                    var armorSetRule = ItemDropRule.Common(ItemType<ShadowFiendHead1>(), 60);
                    armorSetRule.OnSuccess(ItemDropRule.Common(ItemType<ShadowFiendBody1>()));
                    armorSetRule.OnSuccess(ItemDropRule.Common(ItemType<ShadowFiendLegs1>()));
                    npcLoot.Add(armorSetRule);
                    break;
                }
                case NPCID.GoblinSummoner:
                {
                    // 1/25 from Goblin Summoner - Full Set - Shadow Spell Set // tested
                    var armorSetRule = ItemDropRule.Common(ItemType<ShadowSpellHead>(), 25);
                    armorSetRule.OnSuccess(ItemDropRule.Common(ItemType<ShadowSpellBody>()));
                    armorSetRule.OnSuccess(ItemDropRule.Common(ItemType<ShadowSpellLegs>()));
                    npcLoot.Add(armorSetRule);
                    break;
                }
                case NPCID.Paladin:
                case NPCID.BlueArmoredBones:
                case NPCID.BlueArmoredBonesMace:
                case NPCID.BlueArmoredBonesSword:
                case NPCID.BlueArmoredBonesNoPants:
                {
                    // 1/16 from Paladin, 1/100 from Blue Armored Bones - Full Set - Knight of Judgement Set // tested
                    var chanceDenominator = 100;
                    if (npc.type == NPCID.Paladin) chanceDenominator = 16;
                
                    var armorSetRule = ItemDropRule.Common(ItemType<KnightOfJudgementHead>(), chanceDenominator);
                    armorSetRule.OnSuccess(ItemDropRule.Common(ItemType<KnightOfJudgementBody>()));
                    armorSetRule.OnSuccess(ItemDropRule.Common(ItemType<KnightOfJudgementLegs>()));
                    npcLoot.Add(armorSetRule);
                    break;
                }
            }
        }
    }
}
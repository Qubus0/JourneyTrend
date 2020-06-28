﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ExampleMod.Items
{
    public class BossBags : GlobalItem
	{
		public override void OpenVanillaBag(string context, Player player, int arg)
		{
			if (context == "bossBag" && arg == ItemID.FishronBossBag && Main.rand.Next(10) < 1)
			{
				player.QuickSpawnItem(ItemType<JourneyTrend.Items.Vanity.MagicGrill.MagicGrillHead>(), 1);
				player.QuickSpawnItem(ItemType<JourneyTrend.Items.Vanity.MagicGrill.MagicGrillBody>(), 1);
				player.QuickSpawnItem(ItemType<JourneyTrend.Items.Vanity.MagicGrill.MagicGrillLegs>(), 1);
			}
		}
	}
}
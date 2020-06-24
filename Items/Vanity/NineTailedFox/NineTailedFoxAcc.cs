using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.NineTailedFox
{
	[AutoloadEquip(EquipType.Wings)]
	public class NineTailedFoxAcc : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Nine-Tailed Fox Tails");
			Tooltip.SetDefault("Why does the inventory sprite only show 7 tails? Is this a scam?");
		}

		public override void SetDefaults()
		{
			item.accessory = true;
			item.vanity = true;
			item.value = 50000;
			item.rare = ItemRarityID.Lime;
		}

		public override bool WingUpdate(Player player, bool inUse)
		{
			if (inUse)
			{
				player.GetModPlayer<JourneyPlayer>().foxFly = true;
			}
			return false;
		}

		public override void UpdateVanity(Player player, EquipType type)
		{
			player.GetModPlayer<JourneyPlayer>().foxTails = true;
		}
	}
}

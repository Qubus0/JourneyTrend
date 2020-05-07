using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Journeyman
{
	[AutoloadEquip(EquipType.Legs)]
	public class JourneymanLegs : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Journeyman Pants");
			Tooltip.SetDefault("A pair of pants worn by journeymen.\nVanity Item (by poiuygfd)");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 150000;
			item.rare = 0;
			item.vanity = true;
		}
	}
}
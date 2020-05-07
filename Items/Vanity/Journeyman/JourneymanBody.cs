using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Journeyman
{
	[AutoloadEquip(EquipType.Body)]
	public class JourneymanBody : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Journeyman Shirt");
			Tooltip.SetDefault("A fancy jacket worn by journeymen.\nVanity Item (by poiuygfd)");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 150000;
			item.rare = 0;
			item.vanity = true;
		}
		
		public override void DrawHands(ref bool drawHands, ref bool drawArms) {
			drawHands = true;
		}
	}
}
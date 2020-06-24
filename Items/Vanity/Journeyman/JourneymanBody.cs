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
			Tooltip.SetDefault("A fancy jacket worn by journeymen.\nMade by poiuygfd");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 150000;
			item.rare = ItemRarityID.Gray;
			item.vanity = true;
		}

        public override bool CanBurnInLava()
        {
            return false;
        }

        public override void DrawHands(ref bool drawHands, ref bool drawArms) {
			drawHands = true;
		}
	}
}
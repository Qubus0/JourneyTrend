using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Rookie

{
    [AutoloadEquip(EquipType.Wings)]
	public class Hotwings : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Hotwings");
			Tooltip.SetDefault("Spicy");
		}

		public override void SetDefaults() {
			item.width = 22;
			item.height = 20;
			item.rare = ItemRarityID.Red;
			item.vanity = true;
			item.accessory = true;
		}
	}
}
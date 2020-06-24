using JourneyTrend.Items.Vanity;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyTrend.Items.Vanity.NineTailedFox
{
	[AutoloadEquip(EquipType.Head)]
	public class NineTailedFoxHead : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Nine-Tailed Fox Ears");
		}

		public override void SetDefaults()
		{
			item.vanity = true;
			item.value = 50000;
			item.rare = ItemRarityID.Lime;
		}

		public override void DrawHair(ref bool drawHair, ref bool drawAltHair)
		{
			drawHair = true;
			drawAltHair = false;
		}
	}
}

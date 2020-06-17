using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.Localization;

namespace JourneyTrend
{
	public class JourneyTrend : Mod
	{
		public JourneyTrend()
		{
		}
		public override void Load()
		{
		}
		public override void AddRecipeGroups()
		{
			RecipeGroup CyberHalos = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " CyberHalo", new int[]
			{
				ItemType("CyberAngelHead"),
				ItemType("CyberAngelHead1")
			});
			RecipeGroup.RegisterGroup("JourneyTrend:CyberHalos", CyberHalos);

			RecipeGroup DruidMasks = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " DruidMask", new int[]
			{
				ItemType("ForestDruidHead"),
				ItemType("ForestDruidHead1"),
				ItemType("ForestDruidHead2")
			});
			RecipeGroup.RegisterGroup("JourneyTrend:DruidMasks", DruidMasks);
		}
	}
}
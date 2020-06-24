using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyTrend
{
    public class JourneyTrend : Mod
	{
		public static Vector2 ScalePoint(Vector2 a, Vector2 c, float t) => new Vector2(c.X + (t * (a.X - c.X)), c.Y + (t * (a.Y - c.Y)));
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
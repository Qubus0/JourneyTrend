using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;


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
			if (!Main.dedServ)
			{
				AddEquipTexture(null, EquipType.Legs, "PilotBody_Legs", "JourneyTrend/Items/Vanity/Pilot/PilotBody_Legs");
			}
		}
		public override void AddRecipeGroups()
		{
			RecipeGroup CyberHalos = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " CyberHalo", new int[]
			{
				ModContent.ItemType<Items.Vanity.CyberAngel.CyberAngelHead>(),
				ModContent.ItemType<Items.Vanity.CyberAngel.CyberAngelHead1>()
			});
			RecipeGroup.RegisterGroup("JourneyTrend:CyberHalos", CyberHalos);

			RecipeGroup DruidMasks = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " DruidMask", new int[]
			{
				ModContent.ItemType<Items.Vanity.ForestDruid.ForestDruidHead>(),
				ModContent.ItemType<Items.Vanity.ForestDruid.ForestDruidHead1>(),
				ModContent.ItemType<Items.Vanity.ForestDruid.ForestDruidHead2>()
			});
			RecipeGroup.RegisterGroup("JourneyTrend:DruidMasks", DruidMasks);

			RecipeGroup KnightwalkerCapes = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Cape of the Knightwalker", new int[]
			{
				ModContent.ItemType<Items.Vanity.Knightwalker.KnightwalkerBody>(),
				ModContent.ItemType<Items.Vanity.Knightwalker.KnightwalkerBody1>()
			});
			RecipeGroup.RegisterGroup("JourneyTrend:KnightwalkerCapes", KnightwalkerCapes);

			RecipeGroup BubbleHeads = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Bubblehead", new int[]
			{
				ModContent.ItemType<Items.Vanity.Bubblehead.BubbleheadHead>(),
				ModContent.ItemType<Items.Vanity.Bubblehead.BubbleheadHead1>(),
				ModContent.ItemType<Items.Vanity.Bubblehead.BubbleheadHead2>(),
				ModContent.ItemType<Items.Vanity.Bubblehead.BubbleheadHead3>(),
				ModContent.ItemType<Items.Vanity.Bubblehead.BubbleheadHead4>(),
				ModContent.ItemType<Items.Vanity.Bubblehead.BubbleheadHead5>(),
				ModContent.ItemType<Items.Vanity.Bubblehead.BubbleheadHead6>()
			});
			RecipeGroup.RegisterGroup("JourneyTrend:BubbleHeads", BubbleHeads);

			RecipeGroup TerraCrowns = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Terra Crown", new int[]
			{
				ModContent.ItemType<Items.Vanity.Terra.TerraHead>(),
				ModContent.ItemType<Items.Vanity.Terra.TerraHead1>()
			});
			RecipeGroup.RegisterGroup("JourneyTrend:TerraCrowns", TerraCrowns);
		}
	}
}
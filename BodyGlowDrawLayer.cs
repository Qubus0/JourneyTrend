using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace JourneyTrend
{
	public class BodyGlowmaskPlayer : ModPlayer
	{
		private static Dictionary<int, Func<Color>> BodyColor { get; set; }

		/// <summary>
		/// Add glowmask color associated with the body equip slot here, usually in <see cref="ModType.SetStaticDefaults"/>.
		/// <para>Don't forget the !Main.dedServ check!</para>
		/// </summary>
		/// <param name="bodySlot">Body equip slot</param>
		/// <param name="color">Color</param>
		public static void RegisterData(int bodySlot, Func<Color> color)
		{
			if (!BodyColor.ContainsKey(bodySlot))
			{
				BodyColor.Add(bodySlot, color);
			}
		}

		public override void Load()
		{
			BodyColor = new Dictionary<int, Func<Color>>();
		}

		public override void Unload()
		{
			BodyColor = null;
		}

		public override void ModifyDrawInfo(ref PlayerDrawSet drawInfo)
		{
			if (!BodyColor.TryGetValue(Player.body, out Func<Color> color))
			{
				return;
			}

			drawInfo.bodyGlowColor = color();
			drawInfo.armGlowColor = color();
		}
	}
}
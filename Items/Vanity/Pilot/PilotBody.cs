using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyTrend.Items.Vanity.Pilot
{
	[AutoloadEquip(EquipType.Body)]
	public class PilotBody : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pilot's Jumpsuit");
			Tooltip.SetDefault("Parachute not included.\nMade by CyrantontheCold");
		}
		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 14;
			item.rare = ItemRarityID.LightRed;
			item.vanity = true;
		}

		public override void SetMatch(bool male, ref int equipSlot, ref bool robes)
		{
			robes = true;
			equipSlot = mod.GetEquipSlot("PilotBody_Legs", EquipType.Legs);
		}
	}
}
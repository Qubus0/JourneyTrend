using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyTrend.Items.Vanity.Pilot
{
	[AutoloadEquip(EquipType.Body)]
	public class PilotBody : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Arcane Exosuit Skull");
			Tooltip.SetDefault("Resembles the skull of a long extinct species\nMade by Faskeon");
		}
		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 14;
			item.rare = ItemRarityID.Blue;
			item.vanity = true;
		}

		public override void SetMatch(bool male, ref int equipSlot, ref bool robes)
		{
			robes = true;
			equipSlot = mod.GetEquipSlot("PilotBody_Legs", EquipType.Legs);
		}
	}
}
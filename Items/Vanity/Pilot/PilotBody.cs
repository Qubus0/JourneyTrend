using Terraria.ID;
using Terraria.ModLoader;

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
            Item.width = 18;
            Item.height = 14;
            Item.rare = ItemRarityID.LightRed;
            Item.vanity = true;
        }

        public override void SetMatch(bool male, ref int equipSlot, ref bool robes)
        {
            robes = true;
            equipSlot = Mod.GetEquipSlot("PilotLegs_Legs", EquipType.Legs);
        }
    }
}
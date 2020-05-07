using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyTrend.Items.Vanity.RookieSet
{
    [AutoloadEquip(EquipType.Body)]
    public class RookieBody : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rook");
            Tooltip.SetDefault("You tower above.");
        }
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = 1;
            item.vanity = true;
        }
        public override bool DrawBody()
        {
            return false;
        }
        public override void SetMatch(bool male, ref int equipSlot, ref bool robes)
        {
            robes = true;
            equipSlot = mod.GetEquipSlot("RookieBody_Legs", EquipType.Legs);
        }
    }
}
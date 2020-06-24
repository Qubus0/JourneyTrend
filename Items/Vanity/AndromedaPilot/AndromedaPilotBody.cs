using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyTrend.Items.Vanity.AndromedaPilot
{
    [AutoloadEquip(EquipType.Body)]
    public class AndromedaPilotBody : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Arcane Exosuit Ribcage");
            Tooltip.SetDefault("The energy core for the exosuit is damaged but perhaps there is a way to restore it\nMade by Faskeon");
        }
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Blue;
            item.vanity = true;
            item.value = 50000;
        }
    }
}
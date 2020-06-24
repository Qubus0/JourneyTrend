using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyTrend.Items.Vanity.Pilot
{
    [AutoloadEquip(EquipType.Head)]
    public class PilotHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Arcane Exosuit Skull");
            Tooltip.SetDefault("Resembles the skull of a long extinct species\nMade by Faskeon");
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
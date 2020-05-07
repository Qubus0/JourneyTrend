using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyTrend.Items.Vanity.ArcaneExosuit
{
    [AutoloadEquip(EquipType.Body)]
    public class ArcaneExosuitBody : ModItem
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
            item.rare = 1;
            item.vanity = true;
            item.value = 50000;
        }
    }
}
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyTrend.Items.Vanity.Kuijia
{
    [AutoloadEquip(EquipType.Body)]
    public class KuijiaBody : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("[c/ff98ff:Kuijia Platemail]");

            Tooltip.SetDefault("Used by fighters to protect their bodies.\nMade by PatisNow.");
        }
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = 1;
            item.vanity = true;
        }
    }
}
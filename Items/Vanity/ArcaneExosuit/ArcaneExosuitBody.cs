using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.ArcaneExosuit
{
    [AutoloadEquip(EquipType.Body)]
    public class ArcaneExosuitBody : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Arcane Exosuit Ribcage");
            Tooltip.SetDefault(
                "The energy core for the exosuit is damaged but perhaps there is a way to restore it\nMade by Faskeon");
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Blue;
            Item.vanity = true;
            Item.value = 50000;
        }
    }
}
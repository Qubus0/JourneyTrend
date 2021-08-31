using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.ArcaneExosuit
{
    [AutoloadEquip(EquipType.Head)]
    public class ArcaneExosuitHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Arcane Exosuit Skull");
            Tooltip.SetDefault("Resembles the skull of a long extinct species\nMade by Faskeon");
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Blue;
            Item.vanity = true;
            Item.value = 50000;
        }

        public override bool DrawHead()
        {
            return false;
        }
    }
}
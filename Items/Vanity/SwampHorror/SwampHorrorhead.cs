using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.SwampHorror
{
    [AutoloadEquip(EquipType.Head)]
    public class SwampHorrorHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Swamp Horror Mask");
            Tooltip.SetDefault("Made by Outerwar");
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Blue;
            Item.vanity = true;
        }
    }
}
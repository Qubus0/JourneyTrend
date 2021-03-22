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
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Blue;
            item.vanity = true;
        }
    }
}
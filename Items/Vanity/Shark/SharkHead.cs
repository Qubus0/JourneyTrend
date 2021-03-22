using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Shark

{
    [AutoloadEquip(EquipType.Head)]
    public class SharkHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Shark Mask");
            Tooltip.SetDefault("An inflated shark mask.\nDoes not let you breathe underwater.\nMade by Giobun");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Blue;
            item.vanity = true;
            item.value = 0;
        }

        public override bool DrawHead()
        {
            return false;
        }
    }
}
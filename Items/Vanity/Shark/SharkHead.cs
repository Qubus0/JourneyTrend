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
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Blue;
            Item.vanity = true;
            Item.value = 0;
        }

        public override bool DrawHead()
        {
            return false;
        }
    }
}
using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyTrend.Items.Vanity.Mothron
{
    [AutoloadEquip(EquipType.Legs)]
    public class MothronLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Mothron Pants");
            Tooltip.SetDefault("The pattern resembles that of Mothron's abdomen.\nMade by Drdragonfly");
        }
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Blue;
            item.vanity = true;
            item.value = 0;
        }
    }
}
using Terraria.ID;
using Terraria.ModLoader;

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
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Blue;
            Item.vanity = true;
            Item.value = 0;
        }
    }
}
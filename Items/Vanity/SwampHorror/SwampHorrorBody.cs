using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.SwampHorror
{
    [AutoloadEquip(EquipType.Body)]
    public class SwampHorrorBody : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Swamp Horror Shirt");
            Tooltip.SetDefault("Made by Outerwar");
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Blue;
            Item.vanity = true;
        }

        public override bool DrawBody()
        {
            return false;
        }
    }
}
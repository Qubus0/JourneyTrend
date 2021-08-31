using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Mothron
{
    [AutoloadEquip(EquipType.Body)]
    public class MothronBody : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mothron Shirt");
            Tooltip.SetDefault("Fashioned from the thorax of an ancient Kaiju.\nMade by Drdragonfly");
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
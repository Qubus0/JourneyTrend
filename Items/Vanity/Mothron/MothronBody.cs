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
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Blue;
            item.vanity = true;
        }
    }
}
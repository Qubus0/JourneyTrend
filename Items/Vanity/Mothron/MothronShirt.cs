using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyTrend.Items.Vanity.Mothron
{
    [AutoloadEquip(EquipType.Body)]
    public class MothronShirt : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mothron Shirt");
            Tooltip.SetDefault("Fashioned from the thorax of an ancient Kaiju. \nCreated by Drdragonfly");
        }
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = 1;
            item.vanity = true;
        }
        // public override bool DrawBody()
        // {
        //     return false;
        // }
    }
}
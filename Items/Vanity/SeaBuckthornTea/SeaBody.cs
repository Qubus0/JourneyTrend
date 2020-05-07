using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyTrend.Items.Vanity.SeaBuckthornTea
{
    [AutoloadEquip(EquipType.Body)]
    public class SeaBody : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Butler's Vest and Tie");
            Tooltip.SetDefault("With this, you will look well dressed!\nMade by VaeloroK");
        }
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = 1;
            item.vanity = true;
            item.value = 250000;
        }
    }
}
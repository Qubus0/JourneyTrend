using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.SeaBuckthornTea
{
    [AutoloadEquip(EquipType.Body)]
    public class SeaBuckthornTeaBody : ModItem
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
            item.rare = ItemRarityID.Blue;
            item.vanity = true;
            item.value = 250000;
        }
    }
}
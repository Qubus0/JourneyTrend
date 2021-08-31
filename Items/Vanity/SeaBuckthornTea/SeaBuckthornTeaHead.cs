using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.SeaBuckthornTea
{
    [AutoloadEquip(EquipType.Head)]
    public class SeaBuckthornTeaHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("A Cup of Tea");
            Tooltip.SetDefault("It smells like Sea Buckthorn Tea!\nMade by VaeloroK");
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Blue;
            Item.vanity = true;
            Item.value = 250000;
        }

        public override bool DrawHead()
        {
            return false;
        }
    }
}
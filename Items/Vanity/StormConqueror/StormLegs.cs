using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyTrend.Items.Vanity.StormConqueror
{
    [AutoloadEquip(EquipType.Legs)]
    public class StormLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Storm Conqueror's Greaves");
            Tooltip.SetDefault("So comfy.\nMade by Dandandooo.");
        }
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = 9;
            item.vanity = true;
        }
    }
}
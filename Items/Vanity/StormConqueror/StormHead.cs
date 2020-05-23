using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyTrend.Items.Vanity.StormConqueror
{
    [AutoloadEquip(EquipType.Head)]
    public class StormHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Storm Conqueror's Visage");
            Tooltip.SetDefault("Wow, so shiny!\nMade by Dandandooo.");
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
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.ForestDruid
{
    [AutoloadEquip(EquipType.Body)]
    public class ForestDruidBody : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Forest Druid's Robe");
            Tooltip.SetDefault("An ancient robe filled with the forest's essence\nMade by Kohi_aue");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Green;
            item.vanity = true;
        }
    }
}
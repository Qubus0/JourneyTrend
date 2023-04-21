using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Rookie

{
    [AutoloadEquip(EquipType.Wings)]
    public class Hotwings : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hotwings");
            Tooltip.SetDefault("Spicy");
            
            // These wings use the same values as the fledgling wings
            ArmorIDs.Wing.Sets.Stats[Item.wingSlot] = new WingStats(25, 2.5f, 1.5f);
        }

        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 20;
            Item.rare = ItemRarityID.Red;
            Item.vanity = true;
            Item.accessory = true;
            Item.value = 0;
        }
    }
}
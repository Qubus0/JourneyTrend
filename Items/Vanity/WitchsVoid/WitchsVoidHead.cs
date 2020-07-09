using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.WitchsVoid
{
    [AutoloadEquip(EquipType.Head)]
    public class WitchsVoidHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Void Hat");
            Tooltip.SetDefault("It stares back into you\nMade by Hexanne");
        }
        
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Pink;
            item.vanity = true;
        }
    }
}


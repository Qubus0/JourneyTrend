using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyTrend.Items.Vanity.SharkSet
{
    [AutoloadEquip(EquipType.Body)]
    public class SharkBody : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Shark Shirt");
            Tooltip.SetDefault("An inflated shark costume.\nThose fins are moving on their own!\nMade by Giobun");
        }
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = 1;
            item.vanity = true;
        }
    }
}
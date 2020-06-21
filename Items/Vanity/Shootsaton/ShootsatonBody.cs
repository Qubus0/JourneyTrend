using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Shootsaton
{
    [AutoloadEquip(EquipType.Body)]
    public class ShootsatonBody : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sire Shootsaton Jerkin");
            Tooltip.SetDefault("Take aim of your talons in the dark\nMade by Enembra");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Blue;
            item.vanity = true;
        }
    }
}
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.IronCore
{
    [AutoloadEquip(EquipType.Body)]
    public class IronCoreBody : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Breastplate of the Iron Core");
            Tooltip.SetDefault("A worn down chestpiece for an old knight.\nYour heart feels a little heavier when you put this on, but you aren't any stronger.\nMade by TunaToda & RealStiel");
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
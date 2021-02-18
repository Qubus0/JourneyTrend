using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.CosmicTerror
{
    [AutoloadEquip(EquipType.Head)]
    public class CosmicTerrorHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cosmic Terror's Head");
            Tooltip.SetDefault(
                "From the beginning of time, primordial beings rise\n from the endless fear and suffering,\n  to torment this plane of existence.\nMade by RegMeow");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Blue;
            item.vanity = true;
            item.value = 0;
        }

        public override bool DrawHead()
        {
            return false;
        }
    }
}
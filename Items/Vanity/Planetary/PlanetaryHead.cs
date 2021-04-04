using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Planetary
{
    [AutoloadEquip(EquipType.Head)]
    public class PlanetaryHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Planetary Hat");
            Tooltip.SetDefault("Made by Goddigger3_1");
        }
        
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Blue;
            item.vanity = true;
        }

        public override void UpdateVanity(Player player, EquipType type)
        {
            player.GetModPlayer<JourneyPlayer>().PlanetaryHeadEquipped = true;
        }
    }
}


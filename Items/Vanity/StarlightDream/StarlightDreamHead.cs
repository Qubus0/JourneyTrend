using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.StarlightDream
{
    [AutoloadEquip(EquipType.Head)]
    public class StarlightDreamHead : ModItem
    {
        private readonly float adj = 0.00392f / 2; //adjusts the rgb value from 0-255 to 0-1 (/2)

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Starlight Dream Hood");
            Tooltip.SetDefault("Made by Golditale");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Cyan;
            item.vanity = true;
        }

        public override void DrawHair(ref bool drawHair, ref bool drawAltHair)
        {
            drawAltHair = true;
        }

        public override void UpdateVanity(Player player, EquipType type)
        {
            if (!player.GetModPlayer<JourneyPlayer>().StarlightBodyEquipped)
                Lighting.AddLight(player.Center, 241 * adj, 215 * adj, 108 * adj);
        }
    }
}
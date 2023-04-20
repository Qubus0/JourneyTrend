using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.StarlightDream
{
    [AutoloadEquip(EquipType.Body)]
    public class StarlightDreamBody : ModItem
    {
        private readonly float adj = 0.00392f / 2; //adjusts the rgb value from 0-255 to 0-1 (/2)

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Starlight Dream Shirt");
            Tooltip.SetDefault("Made by Golditale");

            ArmorIDs.Body.Sets.HidesHands[Item.bodySlot] = false;
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Cyan;
            Item.vanity = true;
        }

        public override void EquipFrameEffects(Player player, EquipType type)
        {
            player.GetModPlayer<JourneyPlayer>().StarlightDreamBodyEquipped = true;
            Lighting.AddLight(player.Center, 241 * adj, 215 * adj, 108 * adj);
        }
    }
}
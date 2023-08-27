using Terraria.GameContent.Creative;
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
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            // DisplayName.SetDefault("Starlight Dream Hood");
            // Tooltip.SetDefault("Made by Golditale");

            ArmorIDs.Head.Sets.DrawHatHair[Item.headSlot] = true;
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
            if (!player.GetModPlayer<JourneyPlayer>().StarlightDreamBodyEquipped)
                Lighting.AddLight(player.Center, 241 * adj, 215 * adj, 108 * adj);
        }
    }
}
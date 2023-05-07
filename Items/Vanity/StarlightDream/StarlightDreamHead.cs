using Microsoft.Xna.Framework;
using Terraria.GameContent.Creative;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.StarlightDream
{
    [AutoloadEquip(EquipType.Head)]
    public class StarlightDreamHead : ModItem
    {
        private readonly Color LightColor = ColorUtils.DimColor(new Color(241, 215, 108), .5f);

        public override void SetStaticDefaults()
        {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            DisplayName.SetDefault("Starlight Dream Hood");
            Tooltip.SetDefault("Made by Golditale");

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
                Lighting.AddLight(player.Center, ColorUtils.ShaderResponsiveColor(LightColor, player.cHead, player));
        }
    }
}
using Microsoft.Xna.Framework;
using Terraria.GameContent.Creative;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.StarlightDream
{
    [AutoloadEquip(EquipType.Body)]
    public class StarlightDreamBody : ModItem
    {
        private readonly Color LightColor = ColorUtils.DimColor(new Color(241, 215, 108), .5f);

        public override void SetStaticDefaults()
        {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
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
            Lighting.AddLight(player.Center, ColorUtils.ShaderResponsiveColor(LightColor, player.cBody, player));
        }
    }
}
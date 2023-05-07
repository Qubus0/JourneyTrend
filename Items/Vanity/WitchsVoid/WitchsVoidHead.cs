using Microsoft.Xna.Framework;
using Terraria.GameContent.Creative;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.WitchsVoid
{
    [AutoloadEquip(EquipType.Head)]
    public class WitchsVoidHead : ModItem
    {
        private readonly Color LightColor = ColorUtils.DimColor(new Color(240, 152, 239), .5f);

        public override void SetStaticDefaults()
        {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            DisplayName.SetDefault("Void's Eye");
            Tooltip.SetDefault("The numbers '2416' are etched on each piece...how strange.\nMade by Hexanne");
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Pink;
            Item.vanity = true;
        }

        public override void EquipFrameEffects(Player player, EquipType type)
        {
            Lighting.AddLight(player.Center, ColorUtils.ShaderResponsiveColor(LightColor, player.cHead, player));
        }
    }
}
using Microsoft.Xna.Framework;
using Terraria.GameContent.Creative;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.ContainmentSuit
{
    [AutoloadEquip(EquipType.Head)]
    public class ContainmentSuitHead : ModItem
    {
        private readonly Color LightColor = ColorUtils.DimColor(new Color(255, 210, 159), .33f);  

        public override void SetStaticDefaults()
        {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            DisplayName.SetDefault("Containment Helmet");
            Tooltip.SetDefault("A traveler's helmet for harsh environments.\nMade by MikeLeaArt");
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Green;
            Item.vanity = true;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Glass, 2)
                .AddIngredient(ItemID.Wire, 3)
                .AddIngredient(ItemID.Topaz)
                .AddTile(TileID.HeavyWorkBench)
                .Register();
        }

        public override void EquipFrameEffects(Player player, EquipType type)
        {
            Lighting.AddLight(player.Center, ColorUtils.ShaderResponsiveColor(LightColor, player.cHead, player));
        }
    }
}
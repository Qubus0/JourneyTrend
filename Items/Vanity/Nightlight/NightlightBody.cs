using Terraria.GameContent.Creative;
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Nightlight
{
    [AutoloadEquip(EquipType.Body)]
    public class NightlightBody : ModItem
    {
        private readonly Color LightColor = ColorUtils.DimColor(new Color(198, 229, 10), 0.5f);
        
        private static Lazy<Asset<Texture2D>> Glowmask;
        public override void Unload()
        {
            Glowmask = null;
        }

        public override void SetStaticDefaults()
        {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            DisplayName.SetDefault("Nightlight Body");
            Tooltip.SetDefault("A bright friendly glow in the night.\nMade by Metalsquirrel");

            if (!Main.dedServ)
            {
                Glowmask = new(() => ModContent.Request<Texture2D>(Texture + "Glow"));
            
                BodyGlowmaskPlayer.RegisterData(Item.bodySlot, () => new Color(255, 255, 255, 0) * 0.8f);
            }
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Green;
            Item.vanity = true;
            Item.value = 0;
        }

        public override void EquipFrameEffects(Player player, EquipType type)
        {
            Lighting.AddLight(player.Center, ColorUtils.ShaderResponsiveColor(LightColor, player.cBody, player));
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddTile(TileID.Loom)
                .AddIngredient(ItemID.Silk, 15)
                .AddIngredient(ItemID.Moonglow, 15)
                .Register();
        }
    }
}
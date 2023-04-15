using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.ShadowFiend
{
    [AutoloadEquip(EquipType.Body)]
    public class ShadowFiendBody : ModItem
    {
        private static Lazy<Asset<Texture2D>> Glowmask;

        public override void Unload()
        {
            Glowmask = null;
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Shadow Fiend Breastplate");
            Tooltip.SetDefault("Cursed Flames consume you!\nMade by CakeBoiii");

            if (!Main.dedServ)
            {
                Glowmask = new(() => ModContent.Request<Texture2D>(Texture + "Glow"));

                BodyGlowmaskPlayer.RegisterData(Item.bodySlot, () => new Color(255, 255, 255, 0));
            }
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.LightPurple;
            Item.vanity = true;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddTile<Tiles.SewingMachine>()
                .AddRecipeGroup("JourneyTrend:WorldEvilDemonBodies")
                .Register();
        }
    }
}
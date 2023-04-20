using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.ContainmentSuit
{
    [AutoloadEquip(EquipType.Body)]
    public class ContainmentSuitBody : ModItem
    {
        private static Lazy<Asset<Texture2D>> Glowmask;
        public override void Unload()
        {
            Glowmask = null;
        }
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Containment Chestpiece");
            Tooltip.SetDefault("A traveler's chestpiece for harsh environments.\nMade by MikeLeaArt");
            
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
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Silk, 3)
                .AddIngredient(ItemID.Wire, 4)
                .AddRecipeGroup("IronBar", 3)
                .AddTile(TileID.HeavyWorkBench)
                .Register();
        }
    }
}
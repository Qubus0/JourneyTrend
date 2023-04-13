using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Nexus
{
    [AutoloadEquip(EquipType.Body)]
    public class NexusBody : ModItem
    {
        private static Lazy<Asset<Texture2D>> Glowmask;
        public override void Unload()
        {
            Glowmask = null;
        }
        
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nexus Chestplate");
            Tooltip.SetDefault("You sense ceaseless energy coming from within\nMade by LazyGhost14");

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

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddTile(TileID.MythrilAnvil)
                .AddRecipeGroup("IronBar", 20)
                .AddIngredient(ItemID.SoulofSight, 3)
                .AddIngredient(ItemID.Silk, 5)
                .Register();
        }
    }
}
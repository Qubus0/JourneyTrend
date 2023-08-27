using Terraria.GameContent.Creative;
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.CosmicTerror
{
    [AutoloadEquip(EquipType.Body)]
    public class CosmicTerrorBody : ModItem
    {
        private static Lazy<Asset<Texture2D>> Glowmask;
        public override void Unload()
        {
            Glowmask = null;
        }

        public override void SetStaticDefaults()
        {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            // DisplayName.SetDefault("Cosmic Terror's Body");
            /* Tooltip.SetDefault(
                "But he is not the only one;\n there is another cosmic being but him in this world.\nThe destroyer of worlds, the Moon Lord.\nMade by RegMeow"); */
            
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
            Item.rare = ItemRarityID.Blue;
            Item.vanity = true;
            Item.value = 0;
        }
    }
}
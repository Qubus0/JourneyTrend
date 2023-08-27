using Terraria.GameContent.Creative;
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.CyberAngel
{
    [AutoloadEquip(EquipType.Body)]
    public class CyberAngelBody : ModItem
    {
        private static Lazy<Asset<Texture2D>> Glowmask;
        public override void Unload()
        {
            Glowmask = null;
        }
        public override void SetStaticDefaults()
        {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            // DisplayName.SetDefault("Cyber Coat");
            /* Tooltip.SetDefault(
                "The energy is used to purify the corruption and the crimson of the world.\nMade by Rariaz"); */

            ArmorIDs.Body.Sets.HidesHands[Item.bodySlot] = false;
            
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
            Item.rare = ItemRarityID.Cyan;
            Item.vanity = true;
            Item.value = 250000; //only if sold.
        }
    }
}
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.MushroomAlchemist
{
    [AutoloadEquip(EquipType.Body)]
    public class MushroomAlchemistBody : ModItem
    {
        private static Lazy<Asset<Texture2D>> Glowmask;
        public override void Unload()
        {
            Glowmask = null;
        }
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mushroom Alchemist Shirt");
            Tooltip.SetDefault("Makes you feel a little fungi.\nMade by Galahad");

            ArmorIDs.Body.Sets.HidesArms[Item.bodySlot] = false;
            
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
            Item.value = 200000; //only if sold.
        }
    }
}
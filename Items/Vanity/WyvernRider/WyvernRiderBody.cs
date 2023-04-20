using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent; //for dust

namespace JourneyTrend.Items.Vanity.WyvernRider
{
    [AutoloadEquip(EquipType.Body)]
    public class WyvernRiderBody : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Wyvern Rider Shirt");
            Tooltip.SetDefault("It doesn't allow you to ride wyverns, sorry\nMade by manzXja");

            ArmorIDs.Body.Sets.HidesHands[Item.bodySlot] = false;
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Cyan;
            Item.vanity = true;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddTile(TileID.SkyMill)
                .AddIngredient(ItemID.Silk, 8)
                .AddIngredient(ItemID.Cloud, 10)
                .AddIngredient(ItemID.SoulofFlight)
                .Register();
        }

        public override void EquipFrameEffects(Player player, EquipType type)
        {
            if (player.velocity != Vector2.Zero && Main.rand.NextBool(3))
                Dust.NewDust(player.Center + new Vector2(-10 + player.direction * -15, -7), 20, 8,
                    DustType<WyvernRiderDust>());
        }
    }
}
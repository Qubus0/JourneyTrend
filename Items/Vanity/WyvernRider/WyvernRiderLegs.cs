using Terraria.GameContent.Creative;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent; //for dust

namespace JourneyTrend.Items.Vanity.WyvernRider
{
    [AutoloadEquip(EquipType.Legs)]
    public class WyvernRiderLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            DisplayName.SetDefault("Wyvern Rider Pants");
            Tooltip.SetDefault("It doesn't allow you to ride wyverns, sorry\nMade by manzXja");
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
                .AddIngredient(ItemID.Silk, 5)
                .AddIngredient(ItemID.Cloud, 8)
                .AddIngredient(ItemID.SoulofFlight)
                .Register();
        }

        public override void EquipFrameEffects(Player player, EquipType type)
        {
            if (player.velocity != Vector2.Zero && Main.rand.NextBool(5))
                Dust.NewDust(player.Center + new Vector2(-5 + player.direction * -10, 16), 10, 2,
                    DustType<WyvernRiderDust>());
        }
    }
}
using Terraria.GameContent.Creative;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyTrend.Items.Vanity.ShadowFiend
{
    [AutoloadEquip(EquipType.Head)]
    public class ShadowFiendHead : ModItem
    {
        public override void SetStaticDefaults()
        {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            // DisplayName.SetDefault("Shadow Fiend Helmet");
            // Tooltip.SetDefault("Cursed Flames consume you!\nMade by CakeBoiii");
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
            .AddRecipeGroup("JourneyTrend:WorldEvilDemonHeads")
            .Register();
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ItemType<ShadowFiendBody>() && legs.type == ItemType<ShadowFiendLegs>();
        }

        public override void EquipFrameEffects(Player player, EquipType type)
        {
            if (player.velocity != Vector2.Zero && Main.rand.NextFloat() < 0.2f)
                Dust.NewDust(player.Center - new Vector2(player.direction * 10 + 5, 20), 10, 40,
                    DustType<ShadowFiendDust>());
        }
    }
}
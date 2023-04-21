using Terraria.GameContent.Creative;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyTrend.Items.Vanity.ShadowFiend
{
    [AutoloadEquip(EquipType.Head)]
    public class ShadowFiendHead1 : ModItem
    {
        public override void SetStaticDefaults()
        {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            DisplayName.SetDefault("Crimson Scourge Helmet");
            Tooltip.SetDefault("Ichor flows through you!\nMade by CakeBoiii");
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.LightRed;
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
            return body.type == ItemType<ShadowFiendBody1>() && legs.type == ItemType<ShadowFiendLegs1>();
        }

        public override void EquipFrameEffects(Player player, EquipType type)
        {
            if (Main.rand.NextFloat() < 0.05f)
                Dust.NewDust(player.TopLeft, player.width, player.height, DustType<ShadowFiendDust1>());
        }
    }
}
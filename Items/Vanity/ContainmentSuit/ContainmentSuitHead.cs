using Terraria.GameContent.Creative;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.ContainmentSuit
{
    [AutoloadEquip(EquipType.Head)]
    public class ContainmentSuitHead : ModItem
    {
        private readonly float adj = 0.00392f / 3; //adjusts the rgb value from 0-255 to 0-1 (/3)

        public override void SetStaticDefaults()
        {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            // DisplayName.SetDefault("Containment Helmet");
            // Tooltip.SetDefault("A traveler's helmet for harsh environments.\nMade by MikeLeaArt");
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
                .AddIngredient(ItemID.Glass, 2)
                .AddIngredient(ItemID.Wire, 3)
                .AddIngredient(ItemID.Topaz)
                .AddTile(TileID.HeavyWorkBench)
                .Register();
        }

        public override void EquipFrameEffects(Player player, EquipType type)
        {
            Lighting.AddLight(player.Center, 255 * adj, 210 * adj, 159 * adj);
        }
    }
}
using Terraria.GameContent.Creative;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Knightwalker
{
    [AutoloadEquip(EquipType.Head)]
    public class KnightwalkerHead : ModItem
    {
        public override void SetStaticDefaults()
        {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            DisplayName.SetDefault("Helmet of the Knightwalker");
            Tooltip.SetDefault("Made by Dusk Ealain");

            ArmorIDs.Head.Sets.DrawHead[Item.headSlot] = false;
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Purple;
            Item.vanity = true;
        }

        public override void AddRecipes()
        {
            if (WorldGen.crimson)
            {
                CreateRecipe()
                    .AddTile(TileID.Hellforge)
                    .AddIngredient(ItemID.UnicornHorn, 5)
                    .AddIngredient(ItemID.TissueSample, 5)
                    .AddIngredient(ItemID.Ichor, 5)
                    .AddRecipeGroup("IronBar", 10)
                    .Register();
            }
            else
            {
                CreateRecipe()
                    .AddTile(TileID.Hellforge)
                    .AddIngredient(ItemID.UnicornHorn, 5)
                    .AddIngredient(ItemID.ShadowScale, 5)
                    .AddIngredient(ItemID.CursedFlame, 5)
                    .AddRecipeGroup("IronBar", 10)
                    .Register();
            }
        }

        public override void EquipFrameEffects(Player player, EquipType type)
        {
            player.GetModPlayer<JourneyPlayer>().KnightwalkerHeadEquipped = true;
        }
    }
}
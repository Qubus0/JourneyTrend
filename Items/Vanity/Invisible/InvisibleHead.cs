using Terraria.GameContent.Creative;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Invisible
{
    [AutoloadEquip(EquipType.Head)]
    public class InvisibleHead : ModItem
    {
        public override void SetStaticDefaults()
        {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            // DisplayName.SetDefault("Can't");

            ArmorIDs.Head.Sets.DrawHead[Item.headSlot] = false;
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.White;
            Item.vanity = true;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddTile<Tiles.SewingMachine>()
                .AddIngredient(ItemID.Glass)
                .AddCondition(Condition.NearWater)
                .Register();
        }
    }
}
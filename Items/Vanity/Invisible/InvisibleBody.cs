using Terraria.GameContent.Creative;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Invisible
{
    [AutoloadEquip(EquipType.Body)]
    public class InvisibleBody : ModItem
    {
        public override void SetStaticDefaults()
        {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            // DisplayName.SetDefault("See");

            ArmorIDs.Body.Sets.HidesArms[Item.bodySlot] = true;
            ArmorIDs.Body.Sets.HidesTopSkin[Item.bodySlot] = true;
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
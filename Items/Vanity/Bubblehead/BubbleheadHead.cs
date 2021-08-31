using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Bubblehead
{
    [AutoloadEquip(EquipType.Head)]
    public class BubbleheadHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bubble Head");
            Tooltip.SetDefault("Literally a Bubble Head.\nMade by Metidigiti");
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
                .AddIngredient(ItemID.FishBowl)
                .AddIngredient(ItemID.SoulofLight)
                .AddCondition(Recipe.Condition.NearWater)
                .Register();

            CreateRecipe()
                .AddTile<Tiles.SewingMachine>()
                .AddRecipeGroup("JourneyTrend:BubbleHeads")
                .Register();
        }

        public override bool DrawHead()
        {
            return false;
        }

        public override void UpdateVanity(Player player)
        {
            player.GetModPlayer<JourneyPlayer>().BubbleheadHeadEquipped = true;
        }
    }
}
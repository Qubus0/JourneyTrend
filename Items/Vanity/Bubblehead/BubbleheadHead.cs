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
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.LightRed;
            item.vanity = true;
        }

        public override void AddRecipes()
        {
            var recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FishBowl);
            recipe.AddIngredient(ItemID.SoulofLight);
            recipe.needWater = true;
            recipe.SetResult(this);
            recipe.AddRecipe();

            var alt = new ModRecipe(mod);
            alt.AddTile(mod.GetTile("SewingMachine"));
            alt.AddRecipeGroup("JourneyTrend:BubbleHeads");
            alt.SetResult(this);
            alt.AddRecipe();
        }

        public override bool DrawHead()
        {
            return false;
        }

        public override void UpdateVanity(Player player, EquipType type)
        {
            player.GetModPlayer<JourneyPlayer>().BubbleheadHeadEquipped = true;
        }
    }
}
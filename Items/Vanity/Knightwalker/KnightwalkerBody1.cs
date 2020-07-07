using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.Knightwalker
{
    [AutoloadEquip(EquipType.Body)]
    public class KnightwalkerBody1 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mantle of the Knightwalker");
            Tooltip.SetDefault("Scorching Hot\nMade by Dusk Ealain");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Purple;
            item.vanity = true;
        }

        private readonly float adj = 0.00392f/2; //adjusts the rgb value from 0-255 to 0-1 because light is stupid like that
        public override void UpdateVanity(Player player, EquipType type)
        {
            Lighting.AddLight(player.Center, 204 * adj, 82 * adj, 255 * adj);
            player.GetModPlayer<JourneyPlayer>().KnightwalkerBodyEquipped = true;
            player.GetModPlayer<JourneyPlayer>().KnightwalkerAlt = true;
        }

        public override void AddRecipes() 
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddTile(mod.GetTile("SewingMachine"));
            recipe.AddRecipeGroup("JourneyTrend:KnightwalkerCapes");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
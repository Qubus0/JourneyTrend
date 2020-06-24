using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.CyberAngel
{
    [AutoloadEquip(EquipType.Head)]
    public class CyberAngelHead1 : ModItem
    {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Cyber Halo");
            Tooltip.SetDefault("This armor was designed to restrict, control and extract the power and energy of gods, angels and powerful beings.\nMade by Rariaz");
        }
        
        public override void SetDefaults() {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Cyan;
            item.vanity = true;
            item.value = 250000;                             //only if sold.
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddTile(mod.GetTile("SewingMachine"));
            recipe.AddRecipeGroup("JourneyTrend:CyberHalos");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}      
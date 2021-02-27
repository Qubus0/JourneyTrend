using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.CyberAngel
{
    [AutoloadEquip(EquipType.Head)]
    public class CyberAngelHead1 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cyber Halo");
            Tooltip.SetDefault(
                "This armor was designed to restrict,\ncontrol and extract the power and energy of gods,\nangels and powerful beings.\nMade by Rariaz");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Cyan;
            item.vanity = true;
            item.value = 250000; //only if sold.
        }

        public override void AddRecipes()
        {
            var alt = new ModRecipe(mod);
            alt.AddTile(mod.GetTile("SewingMachine"));
            alt.AddRecipeGroup("JourneyTrend:CyberHalos");
            alt.SetResult(this);
            alt.AddRecipe();
        }
    }
}
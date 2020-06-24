using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyTrend.Items.Vanity.AndromedaPilot
{
    [AutoloadEquip(EquipType.Legs)]
    public class AndromedaPilotLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Arcane Exosuit Femora");
            Tooltip.SetDefault("The armor shines a dull gold that could be enchanced with a solar coating\nMade by Faskeon");
        }
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Blue;
            item.vanity = true;
            item.value = 50000;
        }
    }
}
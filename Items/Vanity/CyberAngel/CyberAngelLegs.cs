using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.CyberAngel
{
    [AutoloadEquip(EquipType.Legs)]
    public class CyberAngelLegs : ModItem
    {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Cyber Leggings");
            Tooltip.SetDefault("Some dare to use this armor, but just a few can bear the fatigue, \nonly those who achieve power, wisdom, nimbleness, and kindness are worthy to try this armor.\nMade by Rariaz");
        }
        
        public override void SetDefaults() {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Cyan;
            item.vanity = true;
            item.value = 250000;                             //only if sold.
        }
    }
}

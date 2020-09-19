using Terraria.ID;
using Terraria.ModLoader;


namespace JourneyTrend.Items.Vanity.StormConqueror
{
    [AutoloadEquip(EquipType.Body)]
    public class StormConquerorBody : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Storm Conqueror's Breastplate");
            Tooltip.SetDefault("Ouch, it zapped me!\nMade by Dandandooo");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Cyan;
            item.vanity = true;
        }
    }
}
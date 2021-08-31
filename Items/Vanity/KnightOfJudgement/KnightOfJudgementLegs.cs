using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.KnightOfJudgement
{
    [AutoloadEquip(EquipType.Legs)]
    public class KnightOfJudgementLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Knight of Judgement's Leggings");
            Tooltip.SetDefault("Made by Silvrsterlng");
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Blue;
            Item.vanity = true;
        }
    }
}
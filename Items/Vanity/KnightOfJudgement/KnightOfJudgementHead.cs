using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.KnightOfJudgement
{
    [AutoloadEquip(EquipType.Head)]
    public class KnightOfJudgementHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Knight of Judgement's Helmet");
            Tooltip.SetDefault("Made by Silvrsterlng");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Blue;
            item.vanity = true;
        }
    }
}
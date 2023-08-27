using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.AndromedaPilot
{
    [AutoloadEquip(EquipType.Legs)]
    public class AndromedaPilotLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            // DisplayName.SetDefault("Andromeda Pilot Cetus");
            // Tooltip.SetDefault("Those chains really don't suit you\nMade by Nedrilax");
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Lime;
            Item.vanity = true;
        }
    }
}
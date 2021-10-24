using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.MushroomAlchemist
{
    [AutoloadEquip(EquipType.Body)]
    public class MushroomAlchemistBody : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mushroom Alchemist Shirt");
            Tooltip.SetDefault("Makes you feel a little fungi.\nMade by Galahad");

            ArmorIDs.Body.Sets.HidesArms[Item.bodySlot] = false;
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Blue;
            Item.vanity = true;
            Item.value = 200000; //only if sold.
        }
    }
}
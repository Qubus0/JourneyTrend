using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;


namespace JourneyTrend.Items.Vanity.Rookie
{
    public class HarpyWings : GlobalItem
	{
        public override void Update(Item item, ref float gravity, ref float maxFallSpeed)
        {
            if (item.type == ItemID.HarpyWings && item.lavaWet) {
				item.TurnToAir();
				Item.NewItem(item.Hitbox, ItemType<Hotwings>());
				return;
			}
		}
    }
}

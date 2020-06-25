using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.Items.Vanity.RookieSet
{
    public class HarpyWings : GlobalItem
	{
        public override void Update(Item item, ref float gravity, ref float maxFallSpeed)
        {
            if (item.type == ItemID.HarpyWings && item.lavaWet) {
				item.TurnToAir();
				Item.NewItem(item.Hitbox, mod.ItemType("Hotwings"));
				return;
			}
		}
    }
}

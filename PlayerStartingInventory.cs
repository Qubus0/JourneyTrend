using System.Collections.Generic;
using JourneyTrend.Items.Vanity.Traveller;
using Terraria;
using Terraria.ModLoader;

namespace JourneyTrend;

public class PlayerStartingInventory : ModPlayer
{
    public override IEnumerable<Item> AddStartingItems(bool mediumcoreDeath)
    {
        return new[]
        {
            new Item(ModContent.ItemType<TravellerHead>()),
            new Item(ModContent.ItemType<TravellerBody>()),
            new Item(ModContent.ItemType<TravellerLegs>())
        };
    }
}
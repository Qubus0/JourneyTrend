using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyTrend.World
{
    public class MyModWorld : ModWorld
    {
        public override void PostWorldGen()
        {
            int[] itemsToPlaceInIceChests = { mod.ItemType("IronCoreHead"), mod.ItemType("IronCoreBody"), mod.ItemType("IronCoreLegs") };
            int itemsToPlaceInIceChestsChoice = 0;
            for (int chestIndex = 0; chestIndex < 1000; chestIndex++)
            { // For all chests in world on generation
                Chest chest = Main.chest[chestIndex];
                if (chest != null && Main.tile[chest.x, chest.y].type == TileID.Containers && Main.tile[chest.x, chest.y].frameX == 11 * 36)
                { // If chest type is Ice Chest
                    if (Main.rand.Next(4) < 1)
                    { // 1 in 4 Ice Chests will have the following
                        for (int inventoryIndex = 0; inventoryIndex < 40; inventoryIndex++)
                        { // For each inventory slot in the chest
                            if (chest.item[inventoryIndex].type == 0 && itemsToPlaceInIceChestsChoice < itemsToPlaceInIceChests.Length)
                            { // If selected inventory slot is empty
                                chest.item[inventoryIndex].SetDefaults(itemsToPlaceInIceChests[itemsToPlaceInIceChestsChoice]);
                                itemsToPlaceInIceChestsChoice++;
                            } // Add items!
                        }
                    }
                }
                itemsToPlaceInIceChestsChoice = 0;
            }
        }
    }
}
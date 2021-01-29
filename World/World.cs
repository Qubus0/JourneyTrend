using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyTrend.World
{
    public class MyModWorld : ModWorld
    {
        public override void PostWorldGen()
        {
            int[] itemsToPlaceInIceChests = {ItemType<Items.Vanity.IronCore.IronCoreBag>()};
            int itemsToPlaceInIceChestsChoice = 0;
            int[] itemsToPlaceInLivingChests = { ItemType<Items.Vanity.ForestDruid.ForestDruidBag>() };
            int itemsToPlaceInLivingChestsChoice = 0;
            // For all chests in world on generation
            for (int chestIndex = 0; chestIndex < 1000; chestIndex++)
            {
                Chest chest = Main.chest[chestIndex];
                // If chest type is Ice Chest
                if (chest != null && Main.tile[chest.x, chest.y].type == TileID.Containers && Main.tile[chest.x, chest.y].frameX == 11 * 36)
                {
                  // Sprite for Chests in Tiles_21 -> 12th: Ice Chest, counted from 0 is where 11 comes from. 36 comes from the width of each tile including padding
                  // 1 in 4 chests will have the following
                    if (Main.rand.Next(4) < 1)
                    {
                        // For each inventory slot in the chest
                        for (int inventoryIndex = 0; inventoryIndex < 40; inventoryIndex++)
                        {
                            // If selected inventory slot is empty
                            if (chest.item[inventoryIndex].type == ItemID.None && itemsToPlaceInIceChestsChoice < itemsToPlaceInIceChests.Length)
                            {
                                // Add items!
                                chest.item[inventoryIndex].SetDefaults(itemsToPlaceInIceChests[itemsToPlaceInIceChestsChoice]);
                                itemsToPlaceInIceChestsChoice++;
                            }
                        }
                    }
                }
                itemsToPlaceInIceChestsChoice = 0;
                // If chest type is Living Chest
                if (chest != null && Main.tile[chest.x, chest.y].type == TileID.Containers && Main.tile[chest.x, chest.y].frameX == 12 * 36)
                {
                    // 1 in 2 Living Chests will have the following
                    if (Main.rand.Next(2) < 1)
                    {
                        // For each inventory slot in the chest
                        for (int inventoryIndex = 0; inventoryIndex < 40; inventoryIndex++)
                        {
                            // If selected inventory slot is empty
                            if (chest.item[inventoryIndex].type == ItemID.None && itemsToPlaceInLivingChestsChoice < itemsToPlaceInLivingChests.Length)
                            {
                                // Add items!
                                chest.item[inventoryIndex].SetDefaults(itemsToPlaceInLivingChests[itemsToPlaceInLivingChestsChoice]);
                                itemsToPlaceInLivingChestsChoice++;
                            }
                        }
                    }
                }
                itemsToPlaceInLivingChestsChoice = 0;
            }
        }
    }
}
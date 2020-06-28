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
            for (int chestIndex = 0; chestIndex < 1000; chestIndex++)
            { // For all chests in world on generation
                Chest chest = Main.chest[chestIndex];
                if (chest != null && Main.tile[chest.x, chest.y].type == TileID.Containers && Main.tile[chest.x, chest.y].frameX == 11 * 36)
                { // If chest type is Ice Chest
                  // sprite for Chests in Tiles_21 -> 12th: Ice Chest, counted from 0 is where 11 comes from. 36 comes from the width of each tile including padding
                    if (Main.rand.Next(4) < 1)
                    { // 1 in 4 Ice Chests will have the following
                        for (int inventoryIndex = 0; inventoryIndex < 40; inventoryIndex++)
                        { // For each inventory slot in the chest
                            if (chest.item[inventoryIndex].type == ItemID.None && itemsToPlaceInIceChestsChoice < itemsToPlaceInIceChests.Length)
                            { // If selected inventory slot is empty
                                chest.item[inventoryIndex].SetDefaults(itemsToPlaceInIceChests[itemsToPlaceInIceChestsChoice]);
                                itemsToPlaceInIceChestsChoice++;
                            } // Add items!
                        }
                    }
                }
                itemsToPlaceInIceChestsChoice = 0;

                if (chest != null && Main.tile[chest.x, chest.y].type == TileID.Containers && Main.tile[chest.x, chest.y].frameX == 12 * 36)
                { // If chest type is Living Chest
                    if (Main.rand.Next(2) < 1)
                    { // 1 in 2 Living Chests will have the following
                        for (int inventoryIndex = 0; inventoryIndex < 40; inventoryIndex++)
                        { // For each inventory slot in the chest
                            if (chest.item[inventoryIndex].type == ItemID.None && itemsToPlaceInLivingChestsChoice < itemsToPlaceInLivingChests.Length)
                            { // If selected inventory slot is empty
                                chest.item[inventoryIndex].SetDefaults(itemsToPlaceInLivingChests[itemsToPlaceInLivingChestsChoice]);
                                itemsToPlaceInLivingChestsChoice++;
                            } // Add items!
                        }
                    }
                }
                itemsToPlaceInLivingChestsChoice = 0;
            }
        }
    }
}
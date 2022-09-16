using JourneyTrend.Items.Vanity.MagicGrill;
using JourneyTrend.Items.Vanity.Rookie;
using JourneyTrend.Items.Vanity.StarlightDream;
using JourneyTrend.Items.Vanity.Treesuit;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyTrend.Items
{
    public class BossBags : GlobalItem
    {
        public override void ModifyItemLoot(Item item, ItemLoot itemLoot)
        {
            switch (item.type)
            {
                case ItemID.FishronBossBag:
                {
                    // 1/10 from Duke Fishron - Full Set - Magic Grill Megashark Set Expert Mode
                    var armorSetRule = ItemDropRule.Common(ItemType<MagicGrillHead>(), 10);
                    armorSetRule.OnSuccess(ItemDropRule.Common(ItemType<MagicGrillBody>()));
                    armorSetRule.OnSuccess(ItemDropRule.Common(ItemType<MagicGrillLegs>()));
                    itemLoot.Add(armorSetRule);
                    break;
                }
                case ItemID.WoodenCrate:
                case ItemID.WoodenCrateHard:
                {
                    // 1/40 Any Wooden Crate - Full Set - Tree Suit Set
                    var armorSetRule = ItemDropRule.Common(ItemType<TreesuitHead>(), 10);
                    armorSetRule.OnSuccess(ItemDropRule.Common(ItemType<TreesuitBody>()));
                    armorSetRule.OnSuccess(ItemDropRule.Common(ItemType<TreesuitLegs>()));
                    itemLoot.Add(armorSetRule);
                    break;
                }
            }
        }
    }

    public class FallingStar : GlobalProjectile
    {
        public override bool OnTileCollide(Projectile projectile, Vector2 oldVelocity)
        {
            // falling star (high damage so it ignores stars from star cannon)
            if (projectile.type == 12 && projectile.damage > 500 && Main.rand.Next(300) == 0)
            {
                var dropItemType = ItemType<StarlightDreamBag>();
                var newItem = Item.NewItem(projectile.GetSource_DropAsItem(), projectile.Hitbox, dropItemType);
                Main.item[newItem].noGrabDelay = 0; // Set the new item to be able to be picked up instantly
                
                // Here we need to make sure the item is synced in multiplayer games.
                if (Main.netMode == NetmodeID.MultiplayerClient && newItem >= 0) {
                    NetMessage.SendData(MessageID.SyncItem, -1, -1, null, newItem, 1f);
                }
            }
            
            return base.OnTileCollide(projectile, oldVelocity);
        }
    }

    public class Offset : GlobalItem
    {
        public override void UseStyle(Item item, Player player, Rectangle rectangle)
        {
            if (player.GetModPlayer<JourneyPlayer>().doOffset) //updated in RookieBody.cs
            {
                player.itemLocation.X += 2;
                player.itemLocation.Y += 8;
                player.GetModPlayer<JourneyPlayer>().doOffset = false;
            }
        }
    }

    public class HarpyWings : GlobalItem
    {
        public override void Update(Item item, ref float gravity, ref float maxFallSpeed)
        {
            if (item.type == ItemID.HarpyWings && item.lavaWet)
            {
                item.TurnToAir();
                Item.NewItem(item.GetSource_FromThis(), item.getRect(), ItemType<Hotwings>());
            }
        }
    }
}
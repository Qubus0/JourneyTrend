using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyTrend
{
    public class ModdedPlayer : ModPlayer
    {
        public override void ModifyDrawLayers(List<PlayerLayer> layers)
        {
            if (player.armor[1].type == mod.ItemType("RookieBody"))
            {
                Main.NewText("Say Something");
                PlayerLayer legs = layers.Find(l => l.Name == "Legs");
                if (legs != null)
                {
                    legs.visible = false;
                }
            }
        }
    }
}
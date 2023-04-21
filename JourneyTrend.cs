using System.Linq;
using JourneyTrend.NPCs.Trader;
using Terraria.ModLoader;

namespace JourneyTrend
{
    public class JourneyTrend : Mod
    {
        public override void Load()
        {
            // Will show up in client.log under the JourneyTrend name
            Logger.InfoFormat("{0} Logs: ", Name);
        }

        public override void Unload()
        {
            // All code below runs only if we're not loading on a server
            // if (!Main.dedServ) {
            // 	
            // }

            // Unload static references
            // You need to clear static references to assets (Texture2D, SoundEffects, Effects).
            // In addition to that, if you want your mod to completely unload during unload, you need to clear static references to anything referencing your Mod class
            if (VanityTrader.CurrentShop?.Any() == true)
            {
                VanityTrader.CurrentShop.Clear();
            }
        }
    }
}
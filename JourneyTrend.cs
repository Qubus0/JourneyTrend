using JourneyTrend.Items.Placeable;
using JourneyTrend.NPCs.Trader;
using Terraria.Localization;
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

        public override void PostSetupContent()
        {
            ModLoader.TryGetMod("Census", out Mod censusMod);
            censusMod?.Call(
                "TownNPCCondition",
                ModContent.NPCType<VanityTrader>(),
                Language.GetTextValue(
                    "Mods.JourneyTrend.OtherMods.Census.VanityTraderCondition",
                    ModContent.ItemType<SewingMachine>()
                )
            );
        }
    }
}
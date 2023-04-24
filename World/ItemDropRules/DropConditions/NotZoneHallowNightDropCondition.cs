using Terraria;
using Terraria.GameContent.ItemDropRules;

namespace JourneyTrend.World.ItemDropRules.DropConditions
{
    public class NotZoneHallowNightDropCondition : IItemDropRuleCondition
    {
        public bool CanDrop(DropAttemptInfo info) {
            if (info.IsInSimulation) return false;
            
            return !Main.LocalPlayer.ZoneHallow && !Main.dayTime;
        }

        public bool CanShowItemDropInUI() {
            return true;
        }

        public string GetConditionDescription() {
            return "Drops at night anywhere except the Hallow biome";
        }
    }
}
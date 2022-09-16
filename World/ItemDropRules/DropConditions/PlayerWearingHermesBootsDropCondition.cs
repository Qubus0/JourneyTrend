using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;

namespace JourneyTrend.World.ItemDropRules.DropConditions
{
    public class PlayerWearingHermesBootsDropCondition : IItemDropRuleCondition
    {
        public bool CanDrop(DropAttemptInfo info) {
            if (info.IsInSimulation) return false;

            for (var i = 3; i < 9; i++) // loops through armor slots 3 to 9 (non vanity accessories)
                if (Main.LocalPlayer.armor[i].type == ItemID.HermesBoots) // if one is hermes boots
                    return true;
            
            return false;
        }

        public bool CanShowItemDropInUI() {
            return true;
        }

        public string GetConditionDescription() {
            return "Drops when using Hermes boots";
        }
    }
}
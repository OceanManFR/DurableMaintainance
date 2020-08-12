using Harmony;
using UnityEngine;

namespace DurableMaintainance
{
    [HarmonyPatch(typeof(GearItem), "DegradeOnUse")]
    internal class GearItem_DegradeOnUse
    {
        private static void Prefix(GearItem __instance)
        {
            GameObject go = __instance.gameObject;
            if (go == null) { return; }
            if (go.name == "GEAR_SharpeningStone") { DurableMaintainance.AdjustDegradeOnUse(go, Settings.options.whetPct); }
            if (go.name == "GEAR_RifleCleaningKit") { DurableMaintainance.AdjustDegradeOnUse(go, Settings.options.gunPct); }
        }
    }
}
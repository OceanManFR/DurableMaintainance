using Harmony;
using UnityEngine;

namespace DurableMaintainance
{
    [HarmonyPatch(typeof(Inventory), "AddGear")]
    internal class Inventory_AddGear
    {
        private static void Prefix(GameObject go)
        {
            if (go == null)
            {
                return;
            }
            if (go.name == "GEAR_SharpeningStone") { DurableMaintainance.AdjustDegradeOnUse(go, Settings.options.whetPct); }
            if (go.name == "GEAR_RifleCleaningKit") { DurableMaintainance.AdjustDegradeOnUse(go, Settings.options.gunPct); }
        }
    }
}
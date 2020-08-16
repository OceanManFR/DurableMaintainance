using System.Reflection;
using UnityEngine;
using MelonLoader;

namespace DurableMaintainance
{
    public class DurableMaintainance : MelonMod
    {
        public override void OnApplicationStart()
        {
            Debug.Log("[durable-maintainance] Version " + Assembly.GetExecutingAssembly().GetName().Version);
            Settings.OnLoad();
        }
        internal static void AdjustDegradeOnUse(GameObject gameObject, float value)
        {
            DegradeOnUse degradeOnUse = gameObject.GetComponent<DegradeOnUse>();
            if (degradeOnUse == null) { return; }
            degradeOnUse.m_DegradeHP = value;
        }
    }
}
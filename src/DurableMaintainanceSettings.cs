using ModSettings;

namespace DurableMaintainance
{
    internal class DurableMaintainanceSettings : JsonModSettings
    {
        [Section("Maintainance Tools")]

        [Name("Durability Modifier")]
        [Description("Set this to what percentage you want your whetstone to deteriorate per usage. (Default is 1.)")]
        [Slider(1, 10)]
        public int whetPct = 1;

        [Name("Firearm Cleaning Kit Percentage")]
        [Description("Set this to what percentage you want your firearm cleaning kit to deteriorate per usage. (Default is 1.)")]
        [Slider(1, 10)]
        public int gunPct = 1;
    }
    internal static class Settings
    {
        public static DurableMaintainanceSettings options;

        public static void OnLoad()
        {
            options = new DurableMaintainanceSettings();
            options.AddToModSettings("DurableMaintainance");
        }
    }
}
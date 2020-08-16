using ModSettings;

namespace DurableMaintainance
{
    internal class DurableMaintainanceSettings : JsonModSettings
    {
        [Section("Metal Repair Tools")]

        [Name("Firearm Cleaning Kit")]
        [Description("Set this to what percentage you want your firearm cleaning kit to deteriorate per repair. (Game default is 5.)")]
        [Slider(0, 20)]
        public int firearmCleaningKitPCT = 1;

        [Name("Whetstone")]
        [Description("Set this to what percentage you want your whetstone to deteriorate per repair. (Game default is 5.)")]
        [Slider(0, 20)]
        public int whetstonePCT = 1;

        [Section("Clothing Repair Tools")]
        
        [Name("Sewing Kit")]
        [Description("Set this to what percentage you want your sewing kit to deteriorate per repair. (Game default is 4.)")]
        [Slider(0, 20)]
        public int sewingKitPCT = 1;
        
        [Name("Fishing Tackle")]
        [Description("Set this to what percentage you want your fishing tackle to deteriorate per repair. (Game default is 9.)")]
        [Slider(0, 20)]
        public int fishingTacklePCT = 1;
    }
    internal static class Settings
    {
        public static DurableMaintainanceSettings options;
        public static void OnLoad()
        {
            options = new DurableMaintainanceSettings();
            options.AddToModSettings("Durable Maintainance", MenuType.Both);
        }
    }
}
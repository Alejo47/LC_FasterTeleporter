using System;
using BepInEx;
using HarmonyLib;

namespace FasterTeleporter {
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin {
        internal static Harmony h = new Harmony(PluginInfo.PLUGIN_GUID);

        private void Awake() {
            Logger.LogInfo($"Loading plugin {PluginInfo.PLUGIN_GUID}");
            try {

                h.PatchAll(typeof(Patches.TeleporterPatches));
                Logger.LogInfo($"Loaded plugin {PluginInfo.PLUGIN_GUID}");
            } catch (Exception ex) {
                Logger.LogInfo($"Error loading {PluginInfo.PLUGIN_GUID} (Exception)");
                Logger.LogError(ex.Message);
                Logger.LogError(ex.StackTrace);
            }
        }
    }
}

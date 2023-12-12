using HarmonyLib;

namespace FasterTeleporter.Patches
{
    public static class TeleporterPatches {
        [HarmonyPatch(typeof(ShipTeleporter), "Awake")]
        [HarmonyPostfix]
        static void Awake(bool ___isInverseTeleporter, ref float ___cooldownAmount, ref float ___cooldownTime) {
            if (___isInverseTeleporter) {
                ___cooldownAmount = 0;
                ___cooldownTime = 0;
            }
        }
    }
}


namespace ArcticOverlay.Patches
{

	[HarmonyPatch(typeof(Panel_Base), nameof(Panel_Base.Initialize))]
	internal class AOPanel_Base_Initialize
	{
		private static void Postfix(Panel_Base __instance)
		{
			OverlayManager.Initialize(__instance);
		}
	}

}

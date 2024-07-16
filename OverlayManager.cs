
namespace ArcticOverlay
{
	internal static class OverlayManager
	{
		internal static bool isActive = false;
		internal static string? activeOverlayString = null;

		internal static Dictionary<string,Panel_Base> panels = new Dictionary<string,Panel_Base>();


		internal static void Initialize(Panel_Base panel)
		{
			if (!panels.ContainsKey(panel.name)) {
//				ArcticOverlay.LogDebug($"Initialize -> {panel.name}");
				panel.gameObject.AddComponent<Components.AOComponent>();
				panels.Add(panel.name,panel);
			}
		}

		internal static void Close()
		{
			if (!isActive)
			{
				return;
			}

			activeOverlayString = null;
			isActive = false;
			ArcticOverlay.LogDebug($"Close Overlay -> {activeOverlayString}");
		}

		internal static void Show()
		{
			Stopwatch sw = new Stopwatch();
			sw.Start();
			string activePanels = _getActivePanelString();
			if (activePanels != activeOverlayString)
			{
				activeOverlayString = activePanels;
				isActive = true;
				ArcticOverlay.LogDebug($"Show Overlay -> {activeOverlayString} {sw.Elapsed.TotalMilliseconds}ms");
			}
			sw.Stop();
			sw = null;
		}




		private static string[] _getActivePanels()
		{
			return panels.Select(x=>x.Value).Where(x => x && x.isActiveAndEnabled && !Config.panelsToIgnore.Any(x.name.Equals) && x.GetComponent<UIPanel>().isActiveAndEnabled).Select(x => x.name.Replace("Panel_", "")).ToArray().OrderByDescending(x => x).ToArray();
		}
		private static string? _getActivePanelString()
		{
			return string.Concat(_getActivePanels());
		}

	}
}

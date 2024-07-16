
namespace ArcticOverlay
{
	internal static class OverlayMonitor
	{

		internal static void Check()
		{
			if (!InterfaceManager.s_IsOverlayActive)
			{
				OverlayManager.Close();
			}
			else
			{
				OverlayManager.Show();
			}
		}

	}
}

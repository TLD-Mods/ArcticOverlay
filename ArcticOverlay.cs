
namespace ArcticOverlay
{
	public class ArcticOverlay : MelonMod
	{

		private static bool debug = true;

		public override void OnInitializeMelon()
		{           
			MelonLogger.Msg("Mod started!");
        }

		public override void OnSceneWasLoaded(int buildIndex, string sceneName)
		{
       


        }

        public override void OnUpdate()
		{

		}

		public override void OnFixedUpdate()
		{
			// Monitor for Panel/Overlay changes
			OverlayMonitor.Check();
		}



		internal static void LogDebug(string msg)
		{
			if(debug)
			{
				MelonLogger.Log(System.ConsoleColor.Cyan, msg);
			}
		}



    }
}
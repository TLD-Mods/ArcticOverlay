
namespace ArcticOverlay.Components
{
	[MelonLoader.RegisterTypeInIl2Cpp(false)]
	public class AOComponent : MonoBehaviour
	{

		public string overlayName;
		public GameObject overlay;


		internal void Awake()
		{
			overlayName = gameObject.name.Replace("Panel_","AO_");
			overlay = new GameObject(overlayName);
			overlay.transform.parent = gameObject.transform;
			
		}


	}
}

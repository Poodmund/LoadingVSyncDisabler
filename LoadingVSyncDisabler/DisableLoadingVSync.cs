using UnityEngine;

// Lightweight Kerbal Space Program plugin to ensure that VSync is disabled during the loading screen, code & concept shameless copied from Gameslinx's Parallax mod.

namespace LoadingVSyncDisabler
{
    [KSPAddon((KSPAddon.Startup)(-2), false)]
	public class DisableLoadingVSync : MonoBehaviour
	{
		public void Start()
		{
			QualitySettings.vSyncCount = 0;
		}
	}
}
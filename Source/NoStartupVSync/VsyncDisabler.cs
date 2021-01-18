using System;
using UnityEngine;

namespace VsyncIsBad
{
	[KSPAddon(KSPAddon.Startup.Instantly, false)]
	public class BadVsync : MonoBehaviour
	{
		public void Start()
		{
			QualitySettings.vSyncCount = 0; //BAD Coding Monkey = VSYNC forced on during loading which makes things load slowly.
		}
	}
}
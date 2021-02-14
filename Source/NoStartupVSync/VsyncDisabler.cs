using System;
using UnityEngine;

[assembly: KSPAssembly("NoStartupVSync", 1, 0)]

namespace NoStartupVSync
{
	[KSPAddon(KSPAddon.Startup.Instantly, false)]
	public class FasterLoading : MonoBehaviour
	{
		public void Start()
		{
			QualitySettings.vSyncCount = 0; //BAD Coding = VSYNC forced on during loading which makes things load slower.
		}
	}
}
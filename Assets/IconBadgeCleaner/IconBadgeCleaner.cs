using UnityEngine;
using System.Runtime.InteropServices;

public class IconBadgeCleaner {

	[DllImport("__Internal")]
	static extern void CleanIconBadge_();

	public static void Clean(){
#if UNITY_IOS
		CleanIconBadge_();
#endif
	}
	
}

using System;
using System.Runtime.InteropServices;
using UnityEngine;

class OSHookBridge{
	
#if UNITY_ANDROID

	public static void shareIntent(string text){
		AndroidJavaClass ajc = new AndroidJavaClass("com.kaypee.oshook.Bridge");
		ajc.CallStatic ("shareIntent",text);
	}

#endif

}
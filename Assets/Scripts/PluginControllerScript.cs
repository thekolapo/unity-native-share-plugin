using UnityEngine;
using System.Collections;

public class PluginControllerScript : MonoBehaviour {
	private RuntimePlatform platform = Application.platform;
    public string shareText;

    public void Share() {
		if(platform == RuntimePlatform.Android){
			OSHookBridge.shareIntent (shareText);
		}
       
    }

	//edit this section for sharing to twitter
	public void ShareToTwitter(){
		const string Address = "http://twitter.com/intent/tweet";
		string text = "this minimal plugin was created by @Kolapo_";
		string lang = "en";
		//string related = "@kolapo_";
		Application.OpenURL (Address +"?text=" + WWW.EscapeURL(text) + "&amp;lang=" + WWW.EscapeURL(lang));
		//Application.OpenURL (Address +"?text=" + WWW.EscapeURL(text) + "&amp;related=" + WWW.EscapeURL(related) + "&amp;lang=" + WWW.EscapeURL(lang));
	}

}

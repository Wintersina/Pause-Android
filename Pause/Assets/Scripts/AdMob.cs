using UnityEngine;
using System.Collections;
using admob;

public class AdMob : MonoBehaviour {

	public static AdMob Instance{ set; get; }

	public string bannerId= "placeHolder";
	// Use this for initialization
	void Start () {

		Instance = this;
		DontDestroyOnLoad (gameObject);
		#if UNITY_EDITOR
		#elif UNITY_ANDROID
		Admob.Instance().initAdmob(bannerId, "non");
		Admob.Instance().setTesting(true);
		#endif
	}
	

	public void displayAdds(){
		#if UNITY_EDITOR
		#elif UNITY_ANDROID
		Admob.Instance().showBannerRelative(AdSize.Banner, AdPosition.TOP_CENTER, 0);
		#endif
	
	}
}

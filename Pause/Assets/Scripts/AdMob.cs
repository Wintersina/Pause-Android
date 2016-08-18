using UnityEngine;
using System.Collections;
using admob;

public class AdMob : MonoBehaviour {

	public static AdMob Instance{ set; get; }

	private string bannerId= "ca-app-pub-6947554333794592/9092756042";
	// Use this for initialization
	void Start () {

		Instance = this;
		DontDestroyOnLoad (gameObject);
        #if UNITY_EDITOR
            Debug.Log("adds are going to be shown.");
#elif UNITY_ANDROID
		    Admob.Instance().initAdmob(bannerId, "non");
		    Admob.Instance().setTesting(true);
#endif
#if UNITY_EDITOR
        Debug.Log("adds are being shown.");
#elif UNITY_ANDROID
		            Admob.Instance().showBannerRelative(AdSize.Banner, AdPosition.TOP_CENTER, 0);
#endif
    }


    public void displayAdds(){
        #if UNITY_EDITOR
                Debug.Log("adds are being shown.");
        #elif UNITY_ANDROID
		            Admob.Instance().showBannerRelative(AdSize.Banner, AdPosition.TOP_CENTER, 0);
        #endif

    }
}

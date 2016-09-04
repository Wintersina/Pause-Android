using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class backButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Application.platform == RuntimePlatform.Android && Input.touchCount == 0)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                // if you push the back key, turn off ads
                if (AdMob.isAdsShowwing)
                {
                    AdMob.hide();
                }
                SceneManager.LoadScene("startS4");
                return;
            }
        }
    }
}

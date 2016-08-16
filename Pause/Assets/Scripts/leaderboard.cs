using UnityEngine;
using System.Collections;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;
public class leaderboard : MonoBehaviour {

	// Use this for 

    void Start()
    {
        #if UNITY_EDITOR
        #elif UNITY_ANDROID
        AdMob.Instance.displayAdds();
        #endif
    }
	public void pull_up_leaderboard () {
      
        achievementAPICalls.showLeaderboard();
	}
    public void playTut()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("tutorialS5");
    }
	
}

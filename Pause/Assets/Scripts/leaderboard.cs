using UnityEngine;
using System.Collections;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;
public class leaderboard : MonoBehaviour {

	// Use this for 

    void Start()
    {
        AdMob.show();
    }
	public void pull_up_leaderboard () {
      
        achievementAPICalls.showLeaderboard();
	}
    public void playTut()
    {
        if (AdMob.isAdsShowwing)
            AdMob.hide();
        UnityEngine.SceneManagement.SceneManager.LoadScene("tutorialS5");
    }
	
}

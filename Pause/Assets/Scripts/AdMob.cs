using UnityEngine;
using GoogleMobileAds.Api;


// This class will display adds in the game only when the player is dead for seconds at a time.
// This class was made by Sina Serat
// 9/3/2016
// 
public class AdMob : MonoBehaviour {

  
    private static bool isAdLoaded = false;
    private static BannerView bannerView;
    public static bool isAdsShowwing = true;

    void Start()
    {
       
    }
    void Update()
    {
        if (!isAdLoaded)
        {
            RequestBanner();
        }
    }

    // this method is only called once at the start of the game
    private void RequestBanner(){
        #if UNITY_ANDROID
            string adUnitId = "ca-app-pub-6947554333794592/9092756042";
        #endif

        // Create a 320x50 banner at the top of the screen.
        bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the banner with the request.
        bannerView.LoadAd(request);
        hide();
        isAdLoaded = true;
        
}
    // Will hide it once its called
    public static void hide()
    {
        if (bannerView != null)
        {
            isAdsShowwing = false;
            Debug.Log("Hiding ad");
            bannerView.Hide();
        }
    }

    // will show once its called
    public static void show()
    {
        if (bannerView != null)
        {
            isAdsShowwing = true;
            Debug.Log("Showing ad");
            bannerView.Show();
        }
    }
}

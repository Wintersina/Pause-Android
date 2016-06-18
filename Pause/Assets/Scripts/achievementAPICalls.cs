using UnityEngine;
using System.Collections;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;


// This class does api calls for android or iOs achivments. Depending on their respected phone version.
// All achv are list below, reffer to google API for achi definition.  :D

public class achievementAPICalls : MonoBehaviour
{
    public static void showLeaderboard()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            //----------------------------Android ---------------------------
           PlayGamesPlatform.Instance.ShowLeaderboardUI(StringHolder.leaderboard_highest_speed_reached);

            //---------------------------------------------------------------------------
        }

        else if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            //----------------------------IOS ---------------------------

            //---------------------------------------------------------------------------

        }
    }

    public static void achievement_buy_your_first_ship()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            //----------------------------Android ---------------------------
            Social.ReportProgress(StringHolder.achievement_buy_your_first_ship, 100.00f, (bool success) => { });
            //---------------------------------------------------------------------------
        }

        else if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            //----------------------------IOS ---------------------------

            //---------------------------------------------------------------------------

        }

    }
    public static void achievement_flash()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            //----------------------------Android ---------------------------
            Social.ReportProgress(StringHolder.achievement_flash, 100.00f, (bool success) => { });
            //---------------------------------------------------------------------------
        }

        else if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            //----------------------------IOS ---------------------------

            //---------------------------------------------------------------------------

        }
    }
    public static void achievement_stars()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            //----------------------------Android ---------------------------
            PlayGamesPlatform.Instance.IncrementAchievement(StringHolder.achievement_stars, 1, (bool success) => { });
            //---------------------------------------------------------------------------
        }

        else if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            //----------------------------IOS ---------------------------

            //---------------------------------------------------------------------------

        }

    }
    public static void achievement_buy_all_ships()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            //----------------------------Android ---------------------------
            Social.ReportProgress(StringHolder.achievement_buy_all_ships, 100.00f, (bool success) => { });
            //---------------------------------------------------------------------------
        }

        else if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            //----------------------------IOS ---------------------------

            //---------------------------------------------------------------------------

        }

    }

    public static void achievement_destroyer()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            //----------------------------Android ---------------------------
            PlayGamesPlatform.Instance.IncrementAchievement(StringHolder.achievement_destroyer, 1, (bool success) => { });
            //---------------------------------------------------------------------------
        }

        else if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            //----------------------------IOS ---------------------------

            //---------------------------------------------------------------------------

        }
    }
    public static void achievement_destroyer_2()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            //----------------------------Android ---------------------------
            PlayGamesPlatform.Instance.IncrementAchievement(StringHolder.achievement_destroy_2, 1, (bool success) => { });
            //---------------------------------------------------------------------------
        }

        else if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            //----------------------------IOS ---------------------------

            //---------------------------------------------------------------------------

        }

    }
    public static void achievement_destroyer_3()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            //----------------------------Android ---------------------------
            PlayGamesPlatform.Instance.IncrementAchievement(StringHolder.achievement_destroyer_3, 1, (bool success) => { });
            //---------------------------------------------------------------------------
        }

        else if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            //----------------------------IOS ---------------------------

            //---------------------------------------------------------------------------

        }

    }
    public static void achievement_destroyer_4()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            //----------------------------Android ---------------------------
            PlayGamesPlatform.Instance.IncrementAchievement(StringHolder.achievement_destroyer_4, 1, (bool success) => { });
            //---------------------------------------------------------------------------
        }

        else if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            //----------------------------IOS ---------------------------

            //---------------------------------------------------------------------------

        }

    }
    public static void achievement_destroyer_5()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            //----------------------------Android ---------------------------
            PlayGamesPlatform.Instance.IncrementAchievement(StringHolder.achievement_destroyer_5, 1, (bool success) => { });
            //---------------------------------------------------------------------------
        }

        else if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            //----------------------------IOS ---------------------------

            //---------------------------------------------------------------------------

        }
    }
    public static void achievement_speedster()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            //----------------------------Android ---------------------------
            Social.ReportProgress(StringHolder.achievement_speedster, 100.00f, (bool success) => { });
            //---------------------------------------------------------------------------
        }

        else if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            //----------------------------IOS ---------------------------

            //---------------------------------------------------------------------------

        }
    }
    public static void leaderboard_highest_speed_reached(float value)
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            //----------------------------Android ---------------------------
            Social.ReportScore((int)value, StringHolder.leaderboard_highest_speed_reached, (bool success) => { });
            //---------------------------------------------------------------------------
        }

        else if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            //----------------------------IOS ---------------------------

            //---------------------------------------------------------------------------

        }

    }
    public static void achievement_stars_2()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            //----------------------------Android ---------------------------
            PlayGamesPlatform.Instance.IncrementAchievement(StringHolder.achievement_stars_2, 1, (bool success) => { });
            //---------------------------------------------------------------------------
        }

        else if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            //----------------------------IOS ---------------------------

            //---------------------------------------------------------------------------

        }
    }
    public static void achievement_super_sonic()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            //----------------------------Android ---------------------------
            Social.ReportProgress(StringHolder.achievement_super_sonic, 100.00f, (bool success) => { });
            //---------------------------------------------------------------------------
        }

        else if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            //----------------------------IOS ---------------------------

            //---------------------------------------------------------------------------

        }
    }
    public static void achievement_logged_on_successfully()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            //----------------------------Android ---------------------------
            Social.ReportProgress(StringHolder.achievement_logged_on_successfully, 100.00f, (bool success) => { });
            //---------------------------------------------------------------------------
        }

        else if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            //----------------------------IOS ---------------------------

            //---------------------------------------------------------------------------

        }
    }
    public static void achievement_tutorial_completed()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            //----------------------------Android ---------------------------
            Social.ReportProgress(StringHolder.achievement_tutorial_complete, 100.00f, (bool success) => { });
            //---------------------------------------------------------------------------
        }

        else if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            //----------------------------IOS ---------------------------

            //---------------------------------------------------------------------------

        }
    }
    public static void achievement_death_2()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            //----------------------------Android ---------------------------
            PlayGamesPlatform.Instance.IncrementAchievement(StringHolder.achievement_death_2, 1, (bool success) => { });

            //---------------------------------------------------------------------------
        }

        else if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            //----------------------------IOS ---------------------------

            //---------------------------------------------------------------------------

        }
    }
    public static void achievement_death_3()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            //----------------------------Android ---------------------------
            PlayGamesPlatform.Instance.IncrementAchievement(StringHolder.achievement_death_3, 1, (bool success) => { });

            //---------------------------------------------------------------------------
        }

        else if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            //----------------------------IOS ---------------------------

            //---------------------------------------------------------------------------

        }
    }
    public static void achievement_death_4()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            //----------------------------Android ---------------------------
            PlayGamesPlatform.Instance.IncrementAchievement(StringHolder.achievement_death_4, 1, (bool success) => { });

            //---------------------------------------------------------------------------
        }

        else if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            //----------------------------IOS ---------------------------

            //---------------------------------------------------------------------------

        }
    }
    public static void achievement_death_5()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            //----------------------------Android ---------------------------
            PlayGamesPlatform.Instance.IncrementAchievement(StringHolder.achievement_death_5, 1, (bool success) => { });

            //---------------------------------------------------------------------------
        }

        else if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            //----------------------------IOS ---------------------------

            //---------------------------------------------------------------------------

        }
    }
    public static void achievement_you_have_unclocked_the_secret_ship()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            //----------------------------Android ---------------------------
            Social.ReportProgress(StringHolder.achievement_you_have_unlocked_the_secret_ship, 100.00f, (bool success) => { });
            //---------------------------------------------------------------------------
        }

        else if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            //----------------------------IOS ---------------------------

            //---------------------------------------------------------------------------

        }
    }
    public static void achievement_first_death()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            //----------------------------Android ---------------------------
            Social.ReportProgress(StringHolder.achievement_first_death, 100.00f, (bool success) => { });
            //---------------------------------------------------------------------------
        }

        else if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            //----------------------------IOS ---------------------------

            //---------------------------------------------------------------------------

        }
    }
    public static void achievement_correct_pause()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            //----------------------------Android ---------------------------
            Social.ReportProgress(StringHolder.achievement_correct_pause, 100.00f, (bool success) => { });
            //---------------------------------------------------------------------------
        }

        else if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            //----------------------------IOS ---------------------------

            //---------------------------------------------------------------------------

        }
    }
    public static void achievement_paused()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            //----------------------------Android ---------------------------
            Social.ReportProgress(StringHolder.achievement_paused, 100.00f, (bool success) => { });
            //---------------------------------------------------------------------------
        }

        else if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            //----------------------------IOS ---------------------------

            //---------------------------------------------------------------------------

        }
    }
    public static void achievement_aliens()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            //----------------------------Android ---------------------------
            PlayGamesPlatform.Instance.IncrementAchievement(StringHolder.achievement_aliens, 1, (bool success) => { });
            //---------------------------------------------------------------------------
        }

        else if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            //----------------------------IOS ---------------------------

            //---------------------------------------------------------------------------

        }
    }
    public static void achievement_aliens_2()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            //----------------------------Android ---------------------------
            PlayGamesPlatform.Instance.IncrementAchievement(StringHolder.achievement_aliens_2, 1, (bool success) => { });
            //---------------------------------------------------------------------------
        }

        else if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            //----------------------------IOS ---------------------------

            //---------------------------------------------------------------------------

        }
    }
    public static void achievement_aliens_3()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            //----------------------------Android ---------------------------
            PlayGamesPlatform.Instance.IncrementAchievement(StringHolder.achievement_aliens_3, 1, (bool success) => { });
            //---------------------------------------------------------------------------
        }

        else if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            //----------------------------IOS ---------------------------

            //---------------------------------------------------------------------------

        }
    }
    public static void achievement_aliens_4()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            //----------------------------Android ---------------------------
            PlayGamesPlatform.Instance.IncrementAchievement(StringHolder.achievement_aliens_4, 1, (bool success) => { });
            //---------------------------------------------------------------------------
        }

        else if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            //----------------------------IOS ---------------------------

            //---------------------------------------------------------------------------

        }
    }
    public static void achievement_aliens_5()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            //----------------------------Android ---------------------------
            PlayGamesPlatform.Instance.IncrementAchievement(StringHolder.achievement_aliens_5, 1, (bool success) => { });
            //---------------------------------------------------------------------------
        }

        else if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            //----------------------------IOS ---------------------------

            //---------------------------------------------------------------------------

        }
    }
    public static void achievement_aliens_6()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            //----------------------------Android ---------------------------
            PlayGamesPlatform.Instance.IncrementAchievement(StringHolder.achievement_aliens_6, 1, (bool success) => { });
            //---------------------------------------------------------------------------
        }

        else if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            //----------------------------IOS ---------------------------

            //---------------------------------------------------------------------------

        }
    }

}

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class buttonClicks : MonoBehaviour {

    private string gameS1;
    public Canvas popUpCanvas;
    public static bool playerDied;
	// Use this for initialization
	void Start () {
        popUpCanvas = GameObject.Find("PopUpCanvas").GetComponent<Canvas>();
        gameS1 = "gameS1";
        playerDied = false;
        popUpCanvas.gameObject.SetActive(false);
     
    }
	
	// Update is called once per frame
	void Update () {
        if(playerDied)
        {
            showButton();
            
        }
        if (Application.platform == RuntimePlatform.Android && Input.touchCount == 0)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                SceneManager.LoadScene("startS4");
                return;
            }
        }


    }
    public void replay()
    {
        startMenu.youAreInTutorial = false;
        moveBackGround.speed = 0f;
        score.totalCurrency = 0;
        SceneManager.LoadScene(gameS1);
    }
    public void quit()
    {
        Application.Quit();
    }
    void showButton()
    {
        // save the highscore and speed

        popUpCanvas.gameObject.SetActive(true);
    }
    public void mainMenuButton()
    {
        SceneManager.LoadScene("startS4");
    }
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class movePlayer : MonoBehaviour
{

    Vector3 fingerPos;
    Vector3 textPos;
    private Text startTimer;
    private RectTransform atomText;
    private RectTransform boostText;
    private RectTransform hypeText;
    float startTimerCounter, goTimer;

    void Start()
    {
        //shild timer;
        atomText = GameObject.Find("gotAtomText").GetComponent<RectTransform>();
        boostText = GameObject.Find("boostText").GetComponent<RectTransform>();
        hypeText = GameObject.Find("hypeText").GetComponent<RectTransform>();
        startTimer = GameObject.Find("goText").GetComponent<Text>();
        startTimerCounter = 2f;
        goTimer = 1f;

        startTimer.text = startTimerCounter.ToString("F2");

    }

    // Update is called once per frame
    void Update()
    {
        // show start timer, give player 2 seconds to prep
        startTimerCounter -= Time.timeSinceLevelLoad;

        if (startTimerCounter <= 0)
        {

            startTimer.text = "GO!!!!";
            goTimer -= Time.deltaTime;
            //"GO!" end "GO" and start game
            if (goTimer <= 0)
            {
                startTimer.gameObject.SetActive(false);
            }
            if (Input.touchCount > 0)
            {
                fingerPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.GetTouch(0).position.x, Input.GetTouch(0).position.y, 0));
                textPos = Camera.main.WorldToScreenPoint(transform.position);
            }
            if (Input.touchCount > 0 && Input.touchCount <= 1)
                moveLeft_Right(fingerPos);
        }
        else
        {
            startTimer.text = startTimerCounter.ToString("F2");
        }
    }

    // will move the player left and right baised on touch positions.
    void moveLeft_Right(Vector3 fingerPos)
    {
        //gets a position of the finger on the screen
        //checks position of finger is in bound box
        if (fingerPos.x <= 2.4 && fingerPos.x > -2.4)
        {
            this.transform.position = new Vector3(fingerPos.x, fingerPos.y + 1.5f);

            // Allow text to follow player----------------------------

            atomText.gameObject.SetActive(true);
            hypeText.gameObject.SetActive(true);
            boostText.gameObject.SetActive(true);
            atomText.transform.position = textPos + new Vector3(0, 25, 0);
            hypeText.transform.position = textPos + new Vector3(0, 70, 0);
            boostText.transform.position = textPos + new Vector3(0, -40, 0);

            //--------------------------------------------------------
        }
        else if (fingerPos.x > 2.4)
        {
            this.transform.position = new Vector3(2.4f, fingerPos.y + 1.5f);
        }
        else if (fingerPos.x < -2.4)
        {
            this.transform.position = new Vector3(-2.4f, fingerPos.y + 1.5f);

        }
        
    }

}

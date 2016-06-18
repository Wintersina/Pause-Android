using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class shopingShips : MonoBehaviour {

    //if button is clicked move ship;
    public static bool buttonIsClicked;

    public static int shipTotal = 12;
    public static GameObject[] ships = new GameObject[shipTotal];
    public Button[] shipButtons = new Button[shipTotal];
    private string[] shipNames = new string[shipTotal];
    private float[] shipCost = new float[shipTotal];
    
    public static int shipNumber;
    private static int spawnShipNumber;
    public static int LastShipSelected;

    // pop up canvis section
    public static GameObject popUpCanvis;
    public static GameObject buttonCanvis;
    public Image shipImg;
    public Button yesButton;
    public Button noButton;
    public Text question;
    // star dust controll
    //public Text notEnoughStarDust;
    private float notEnoughStarDustTimer;

    public Text starDust;

    // Use this for initialization
    void Start() {

  

        starDust.text = "Start Dust: " + PlayerPrefs.GetFloat("PlayerCurrecny").ToString("F2");
        buttonCanvis = GameObject.Find("Canvas");
        buttonCanvis.gameObject.SetActive(true);
        popUpCanvis = GameObject.Find("PopUpCanvas");
        popUpCanvis.gameObject.SetActive(false);
        notEnoughStarDustTimer = 0.0f;

        // initilizing the cost of ships. Each ship has a differnt cost
        shipCost[0] = 0;
        shipCost[1] = 2000f;
        shipCost[2] = 100f;
        shipCost[3] = 500f;
        shipCost[4] = 400f;
        shipCost[5] = 50f;
        shipCost[6] = 30;
        shipCost[7] = 25;
        shipCost[8] = 100;
        shipCost[9] = 250;
        shipCost[10] = 100;

        // initilizing the names of ships
        shipNames[0] = "";
        shipNames[1] = "Perry";
        shipNames[2] = "Phaser";
        shipNames[3] = "Turtle";
        shipNames[4] = "Paranoid";
        shipNames[5] = "Tutorial";
        shipNames[6] = "Classic";
        shipNames[7] = "Desert";
        shipNames[8] = "Saucer";
        shipNames[9] = "Ovary";
        shipNames[10] = "Ninja";
        shipNames[11] = "NASA2095";

        // setting index zeros to null for having an empty object
        ships[0] = null;
        shipButtons[0] = null;
        
        shipNumber = 0;
        LastShipSelected = 0;
        if (PlayerPrefs.GetInt("spawnShip") == 0)
        {
            spawnShipNumber = 0;
            PlayerPrefs.SetInt("spawnShip", spawnShipNumber);
        }
        // will find every button in this secene and give player option to buy a ship. if player has already bought it will not show
        // buy as an option
        for (int i = 1; i <= ships.Length-1; i++)
        {      
            ships[i] = GameObject.Find("ship" + i.ToString());
            shipButtons[i] = GameObject.Find("Button" + i.ToString()).GetComponent<Button>();
            
        }
        //Debug.Log(PlayerPrefs.GetFloat("PlayerCurrecny").ToString("F2"));
	
	}
	
	// Update is called once per frame
	void Update () {
        notEnoughStarDustTimer -= Time.deltaTime;

    }
    // redo this function later for efficincy
    // what this function does :
    //   seaches for the index in prefab by checking what button was pushed. if that button was pushed then
    //   keep track of the ship number selected. once player pushes start
    public void shipselected()
    {
        for (int i = 1; i < ships.Length; i++)
        {
            if(EventSystem.current.currentSelectedGameObject.name == "Button" + i.ToString()) {

                // if you have bought the current ship
                if (PlayerPrefs.GetString("boughtship"+i.ToString()) == "True")
                {
                    buttonCanvis.SetActive(false);
                    popUpCanvis.SetActive(true);
                    
                    shipImg.sprite = ships[i].gameObject.GetComponentInChildren<Image>().sprite;
                    question.text = "You Have Already Bought " + shipNames[i] + " star ship.";
                    Text changeyestoOk = yesButton.gameObject.GetComponentInChildren<Text>();
                    Text changenotoCancel = noButton.gameObject.GetComponentInChildren<Text>();
                    changenotoCancel.text = "Cancel";
                    changeyestoOk.text = "Select";
                    //used for selecting the previously selected ships
                    LastShipSelected = shipNumber;
                    shipNumber = i;
                }
                // if ship was not bought yet
                else {
                    
                    buttonCanvis.SetActive(false);
                    popUpCanvis.SetActive(true);
                    shipImg.sprite = ships[i].gameObject.GetComponentInChildren<Image>().sprite;
                    question.text = "Cost: "+shipCost[i]+ " StarDust. \n\n" + "Would you like to buy the " + shipNames[i] + " ship?";
                    Text changeyestoOk = yesButton.gameObject.GetComponentInChildren<Text>();
                    changeyestoOk.text = "Yes";
                    Text changenotoCancel = noButton.gameObject.GetComponentInChildren<Text>();
                    changenotoCancel.text = "No";
                    LastShipSelected = shipNumber;
                    shipNumber = i;

                    
                }
            }
        }
    }

    // will not need this function
   
    public void yes_no()
    {
        // if you push yes.
        if (EventSystem.current.currentSelectedGameObject.name == "Yes Button")
        {   // if the player has pushed yet and has bought the ship
            if (PlayerPrefs.GetString("boughtship" + shipNumber.ToString()) == "True")
            {
                
                spawnShipNumber = shipNumber;
                startMenu.spawnTracker = spawnShipNumber;               // used incase player goses back to main menu
                PlayerPrefs.SetInt("spawnShip", spawnShipNumber);
                rotateRight.shipSelected = shipNumber;
                buttonCanvis.SetActive(true);
                popUpCanvis.SetActive(false);
            }   //if the player has not bought the ship
            else if (PlayerPrefs.GetFloat("PlayerCurrecny") >= shipCost[shipNumber])
            {
                spawnShipNumber = shipNumber;
                startMenu.spawnTracker = spawnShipNumber;               // used incase player goes back to main menu
                PlayerPrefs.SetInt("spawnShip", spawnShipNumber);
                rotateRight.shipSelected = shipNumber;
                // reduce cost, switch canvases and show new cost
                PlayerPrefs.SetFloat("PlayerCurrecny", PlayerPrefs.GetFloat("PlayerCurrecny") - shipCost[shipNumber]);
                starDust.text = "Start Dust: " + PlayerPrefs.GetFloat("PlayerCurrecny").ToString("F2");
                buttonCanvis.SetActive(true);
                popUpCanvis.SetActive(false);
                PlayerPrefs.SetString("boughtship" + shipNumber.ToString(), "True");
            } // else they dont have enough star dust
            else
            {
                if (notEnoughStarDustTimer <= 0)
                {
                    //notEnoughStarDust.text = "Not Enough StarDust to buy this....";
                    notEnoughStarDustTimer = 2.0f;
                }

            }// if you push no
        }
        else if (EventSystem.current.currentSelectedGameObject.name == "No Button")
        { 
            buttonCanvis.SetActive(true);
            popUpCanvis.SetActive(false);
        }
    }
       
    public static void turnOffCanves()
    {
        buttonCanvis.gameObject.SetActive(false);
        popUpCanvis.gameObject.SetActive(false);
    }
}

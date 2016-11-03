using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class rotateRight : MonoBehaviour {

    private GameObject[] Targets = new GameObject[shopingShips.shipTotal];
    private GameObject[] startingPoss = new GameObject[shopingShips.shipTotal];
    private static bool[] checkedOut = new bool[shopingShips.shipTotal];
    private GameObject liftOffLeft;
    private GameObject liftOffRight;
    public static bool flyOffChecker;
    public static float flyOffTimer;
    public GameObject[] boost = new GameObject[shopingShips.shipTotal];

    public static int shipSelected;

   void Start()
    {
        //boost[0] = null;
        flyOffChecker = false;
        flyOffTimer = 1000;
        liftOffLeft = GameObject.Find("LiftOffLeft");
        liftOffRight = GameObject.Find("LiftOffRight");
        shipSelected = 0;
        // find all game objects within the current scene and assign them apporpriatly 
        for (int i = 1; i < shopingShips.shipTotal; i++)
        {
            boost[i] = GameObject.Find("Boost"+i.ToString());
            boost[i].gameObject.SetActive(false);
            startingPoss[i] = GameObject.Find("return" + i.ToString());
            Targets[i] = GameObject.Find("face"+i.ToString());
            checkedOut[i] = false;
        }
        

        // find faces;
    }

    //every frame of the game, the game checks if a ship has been checked out.
    // it will then find all other ships and place them back to their original spot.
    // it will also boost the ships out into the nexus if a player selects lift off.
    void Update()
    {  
        if (shipSelected != 0)
        {
               shopingShips.ships[shipSelected].transform.position = Vector3.MoveTowards(shopingShips.ships[shipSelected].gameObject.transform.position, Targets[shipSelected].transform.position, .03f);
                // Find whatever ship was checked out and return it to its position
                for (int k = 1; k < shopingShips.shipTotal;  k++)
                {
                    if(k != shipSelected)
                    {
                        shopingShips.ships[k].transform.position = Vector3.MoveTowards(shopingShips.ships[k].gameObject.transform.position, startingPoss[k].transform.position, .03f);
                    }
            }
        }
        flyOffTimer -= Time.deltaTime;
        if (flyOffChecker && shipSelected != 0)
        {
            // each ship takes off to its own unique location
            boost[shipSelected].gameObject.SetActive(true);
           if(shipSelected %2 == 0)
            {

              shopingShips.ships[shipSelected].transform.position = Vector3.MoveTowards(shopingShips.ships[shipSelected].gameObject.transform.position, liftOffRight.transform.position, .1f);
            }
            else
            {
                shopingShips.ships[shipSelected].transform.position = Vector3.MoveTowards(shopingShips.ships[shipSelected].gameObject.transform.position, liftOffLeft.transform.position, .1f);
            }
        }
        if (flyOffTimer <= 0)
        {
            SceneManager.LoadScene("gameS1");
        }
    }
}

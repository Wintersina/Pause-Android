using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class popUpMenu : MonoBehaviour {

    public GameObject canves;

    // Use this for initialization
    void Start() {
    }

    void Update()
    {
        if (Input.touchCount > 0 && Input.touchCount <= 1 && !buttonClicks.playerDied)
        {
            canves.gameObject.SetActive(false);
        }
        else
            canves.gameObject.SetActive(true);


    }


}

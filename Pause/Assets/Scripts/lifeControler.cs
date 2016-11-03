using UnityEngine;
using System.Collections;

public class lifeControler : MonoBehaviour {


    private SpriteRenderer spriteControl;
    public Sprite []img = new Sprite[3];
    private string extention;
    private string []shipNames= new string[shopingShips.shipTotal];

    // Use this for initialization
    void Start() {

        shipNames[0] = "non";
        shipNames[1] = "Proteus";
        shipNames[2] = "Amadeus";

        spriteControl = this.gameObject.GetComponent<SpriteRenderer>();
        if (this.gameObject.name.Contains("(Clone)"))
        {
            extention = this.gameObject.name;
            extention = extention.Replace("(Clone)", "");
        }
        else
            extention = this.gameObject.name;

        extention = extention.Replace("ship", "");
   
        img = Resources.LoadAll<Sprite>("prefabs/Ships/Sprites/" + shipNames[int.Parse(extention)].ToString() );
        spriteControl.sprite = img[collisionDetection.lifeCounter];
    }
	
	// Update is called once per frame
	void Update () {

        spriteControl.sprite = img[collisionDetection.lifeCounter];
	
	}
}

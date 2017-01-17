using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PictureHandler : MonoBehaviour {

    public GameObject pictureDisplay;
    public Sprite[] images;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetPicture(string picture)
    {

        switch (picture)
        {

            case "Kitty":
                pictureDisplay.GetComponent<Image>().sprite = images[0];
                break;

            case "Doggie":
                pictureDisplay.GetComponent<Image>().sprite = images[1];
                break;

            case "Cow":
                pictureDisplay.GetComponent<Image>().sprite = images[2];
                break;

            case "Sheep":
                pictureDisplay.GetComponent<Image>().sprite = images[3];
                break;
        }

    }
}

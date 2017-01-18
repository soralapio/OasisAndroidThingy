using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PictureHandler : MonoBehaviour {

    public GameObject pictureDisplay;
	public Sprite defaultPicture;
    public Sprite[] images;

	// Use this for initialization
	void Start () {

		//pictureDisplay.transform.localScale -= new Vector3(1f, 1f, 1f);
		pictureDisplay.GetComponent<Image> ().sprite = defaultPicture;
		
	}

	void Reset() 
	{
		pictureDisplay.transform.localScale -= new Vector3 (2f, 2f, 2f);
		pictureDisplay.GetComponent<Image> ().sprite = defaultPicture;

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetPicture(string picture)
    {
		pictureDisplay.transform.localScale += new Vector3 (2f, 2f, 2f);

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

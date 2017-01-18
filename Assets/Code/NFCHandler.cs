using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NFCHandler : MonoBehaviour {

    public GameObject textToChange;
    public GameObject pictureHandler;
    public GameObject soundManager;

	private bool tagScanned = false;
	private float scanDelta = 0f;
	public float scanDuration = 2f;
    
    // Use this for initialization
    void Start () {
        AndroidNFCReader.enableBackgroundScan();
        AndroidNFCReader.ScanNFC("NFCHandler", "OnFinishScan");

	}
	
	// Update is called once per frame
	void Update () {

		if (tagScanned) 
		{

			scanDelta += Time.deltaTime;

			if (scanDelta >= scanDuration) 
			{

				pictureHandler.SendMessage ("Reset");
				tagScanned = false;
				scanDelta = 0f;
			}

		}
        
    }

    void OnFinishScan(string result)
    {

        if (result == AndroidNFCReader.CANCELLED)
        {

            textToChange.GetComponent<Text>().text = "SCAN CANCELLED";

        }

        else if (result == AndroidNFCReader.ERROR)
        {

            textToChange.GetComponent<Text>().text = "ERROR!";

        }

        else if (result == AndroidNFCReader.NO_HARDWARE)
        {

            textToChange.GetComponent<Text>().text = "NFC READER NOT FOUND!";

        }

        else
        {
			
            switch (result)
            { 
            case "043B77EA1D4E80":
				tagScanned = true;
                textToChange.GetComponent<Text>().text = "It's a kitty!";
                soundManager.GetComponent<SoundManager>().PlaySound("Kitty");
                pictureHandler.GetComponent<PictureHandler>().SetPicture("Kitty");
            break;

            case "044E77EA1D4E80":
				tagScanned = true;
                textToChange.GetComponent<Text>().text = "It's a doge!";
                soundManager.GetComponent<SoundManager>().PlaySound("Doggie");
                pictureHandler.GetComponent<PictureHandler>().SetPicture("Doggie");
            break;

            case "043A77EA1D4E80":
				tagScanned = true;
                textToChange.GetComponent<Text>().text = "It's a cow!";
                soundManager.GetComponent<SoundManager>().PlaySound("Cow");
                pictureHandler.GetComponent<PictureHandler>().SetPicture("Cow");
            break;

            case "042777EA1D4E80":
				tagScanned = true;
                textToChange.GetComponent<Text>().text = "It's a sheep!";
                soundManager.GetComponent<SoundManager>().PlaySound("Sheep");
                pictureHandler.GetComponent<PictureHandler>().SetPicture("Sheep");
            break;

            default:
                textToChange.GetComponent<Text>().text = "I don't know that tag:" + result;
            break;
            }

        }
    }
}

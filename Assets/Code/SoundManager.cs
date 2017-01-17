using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    public AudioClip[] audioClips;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PlaySound(string sound)
    {

        switch (sound)
        {

        case "Kitty":
            gameObject.GetComponent<AudioSource>().PlayOneShot(audioClips[0]);
        break;

        case "Doggie":
            gameObject.GetComponent<AudioSource>().PlayOneShot(audioClips[1]);
        break;

        case "Cow":
            gameObject.GetComponent<AudioSource>().PlayOneShot(audioClips[2]);
        break;

        case "Sheep":
            gameObject.GetComponent<AudioSource>().PlayOneShot(audioClips[3]);
        break;
        }

    }


}

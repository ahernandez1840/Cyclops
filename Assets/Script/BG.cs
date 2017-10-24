using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG : MonoBehaviour {


    AudioSource myAudio;

    public AudioClip bg;
    // Use this for initialization
    void Start () {

        myAudio = GetComponent<AudioSource>();
        myAudio.PlayOneShot(bg);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

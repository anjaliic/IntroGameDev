using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Nina: general class that will just play a sound for you
//when you call upon the static audiosource object
//call soundManager.playSound("yourClip");

public class soundManager : MonoBehaviour {

	public static AudioSource source;


	// Use this for initialization
	void Start () {
		source = gameObject.GetComponent<AudioSource> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public static void playSound(AudioClip clip){
		source.PlayOneShot (clip);
	}
}

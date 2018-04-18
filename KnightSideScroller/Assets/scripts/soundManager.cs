using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Nina: general class that will just play a sound for you
//when you call upon the static audiosource object
//call soundManager.playSound("yourClip");

public class soundManager : MonoBehaviour {

	public static AudioSource source;

	void Start () 
	{
		source = gameObject.GetComponent<AudioSource> ();
		
	}
	
	void Awake()
	{
		DontDestroyOnLoad (this);
	}

	public static void playSound(AudioClip clip)
	{
		source.PlayOneShot (clip);
	}
}

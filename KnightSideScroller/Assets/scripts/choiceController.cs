using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choiceController : MonoBehaviour {

	public static choiceController _choice;

	public AudioClip itemCollect;
	AudioSource choiceAudio;

	// Use this for initialization
	void Start () 
	{
		_choice = this;
		choiceAudio = GetComponent<AudioSource> ();
		choiceAudio.clip = itemCollect;
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		armorChoice ();

		StarterGold ();

		searchChoice ();
	}

	void armorChoice ()
	{
		if (gameManager.gameMng.choiceArmor == false && this.gameObject.tag.Equals ("armor")) 
		{
			this.gameObject.SetActive (false);
			if (this.gameObject.name.Equals ("armor1"))
			{
				gameManager.gameMng.armor1 = true;
				GetComponent<AudioSource> ().Play ();
				Debug.Log ("armor 1 = true");
			}
			if (this.gameObject.name.Equals ("armor2"))
			{
				gameManager.gameMng.armor2 = true;
				GetComponent<AudioSource> ().Play ();
				Debug.Log ("armor2 = true");
			}
			gameManager.gameMng.choiceArmor = true;
		}
	}

	void StarterGold ()
	{
		if (this.gameObject.tag.Equals ("gold")) 
		{
			this.gameObject.SetActive (false);
			if (this.gameObject.name.Equals ("startergold")) 
			{
				gameManager.gameMng.wealth++;
			}
			gameManager.gameMng.starterGold = true;
		}
	}

	void searchChoice ()
	{
		if (gameManager.gameMng.choiceSearch == false && this.gameObject.tag.Equals ("search")) 
		{
			this.gameObject.SetActive (false);
			if (this.gameObject.name.Equals ("search1"))
			{
				gameManager.gameMng.search1 = true;
			}
			if (this.gameObject.name.Equals ("search2")) 
			{
				gameManager.gameMng.search2 = true;
			}
			gameManager.gameMng.choiceSearch = true;
		}
	}
}

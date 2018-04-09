using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choiceController : MonoBehaviour {

	public static choiceController _choice;

	AudioSource choiceAudio;

	public Sprite choice;

	void Start () 
	{
		_choice = this;
		choiceAudio = GetComponent<AudioSource> ();
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		armorChoice ();
		StarterGold ();
		searchChoice ();

		if (gameManager.gameMng.choiceGift == false && this.gameObject.transform.parent.name.Equals("Gift")) 
		{
			this.gameObject.SetActive (false);
			if (this.gameObject.name.Equals ("g1"))
			{
				gameManager.gameMng.gift1 = true;
			}
			if (this.gameObject.name.Equals ("g2"))
			{
				gameManager.gameMng.gift2 = true;
			}
			if (this.gameObject.name.Equals ("g3"))
			{
				gameManager.gameMng.gift3 = true;
			}
			gameManager.gameMng.choiceGift = true;
		}
	}

	void armorChoice ()
	{
		if (gameManager.gameMng.choiceArmor == false && this.gameObject.transform.parent.name.Equals("Armor")) 
		{
			this.gameObject.SetActive (false);
			if (this.gameObject.name.Equals ("armor1"))
			{
//				choiceAudio.PlayOneShot(1);
				gameManager.gameMng.armor1 = true;
			}
			if (this.gameObject.name.Equals ("armor2"))
			{
//				choiceAudio.PlayOneShot (1);
				gameManager.gameMng.armor2 = true;
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

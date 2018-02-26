using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choiceController : MonoBehaviour {

	public static choiceController _choice;

	// Use this for initialization
	void Start () 
	{
		_choice = this;
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		armorChoice ();

		Item_1Choice ();

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
				Debug.Log ("armor 1 = true");
			}
			if (this.gameObject.name.Equals ("armor2"))
			{
				gameManager.gameMng.armor2 = true;
				Debug.Log ("armor2 = true");
			}
			gameManager.gameMng.choiceArmor = true;
		}
	}

	void Item_1Choice ()
	{
		if (gameManager.gameMng.choiceItem == false && this.gameObject.tag.Equals ("item_1")) 
		{
			this.gameObject.SetActive (false);
			if (this.gameObject.name.Equals ("item1")) 
			{
				gameManager.gameMng.item1 = true;
				gameManager.gameMng.strength++;
			}
			if (this.gameObject.name.Equals ("item2")) 
			{
				gameManager.gameMng.item2 = true;
				gameManager.gameMng.cunning++;
			}
			if (this.gameObject.name.Equals ("item3")) 
			{
				gameManager.gameMng.item3 = true;
				gameManager.gameMng.wealth++;
			}
			gameManager.gameMng.choiceItem = true;
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

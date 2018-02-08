using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choiceList : MonoBehaviour {

	public static choiceList _choice;

	// Use this for initialization
	void Start () 
	{
		_choice = this;
	}
	
	void OnCollisionEnter2D(Collision2D collision)
	{
		armorChoice ();
	}

	void armorChoice ()
	{
		if (playerChoices.Choice.choiceArmor == false && this.gameObject.tag.Equals ("armor")) 
		{
			this.gameObject.SetActive (false);
			if (this.gameObject.name.Equals ("armor1"))
			{
				playerChoices.Choice.armor1 = true;
				Debug.Log ("armor 1 = true");
			}
			if (this.gameObject.name.Equals ("armor2"))
			{
				playerChoices.Choice.armor2 = true;
				Debug.Log ("armor2 = true");
			}
			playerChoices.Choice.choiceArmor = true;
		}
	}
}

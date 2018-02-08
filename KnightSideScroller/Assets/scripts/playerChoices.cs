using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerChoices : MonoBehaviour {

	public static playerChoices Choice;

	//armor choice
	public bool choiceArmor = false;
//	public int armor;
	public bool armor1;
	public bool armor2;

	//steed choice
	public bool choiceSteed = false;
	public bool steed1;
	public bool steed2;
	public bool steed3;

	void Start()
	{
		Choice = this;
	}

	void Update()
	{
//		if (choiceArmor == true && gameObject.tag.Equals ("armor1")) 
//			{
//			Destroy (gameObject);
//			}
//		if (armor1 == true || armor2 == true)
//		{
//			choiceArmor = true;
//		}

//		switch (armor)
//		{
//		case 1:
//			armor1 = true;
//			break;
//
//		case 2:
//			armor2 = true;
//			break;
//		}

	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		armorChoice ();

		steedChoice ();
	}

	void armorChoice ()
	{
		if (choiceArmor == false)
		{
			gameObject.SetActive (false);

			if (this.gameObject.name.Equals ("armor1")) 
			{
				armor1 = true;
				Debug.Log ("armor 1 = true");
//				armor = 1;
			}
			if (this.gameObject.name.Equals ("armor2")) 
			{
				armor2 = true;
				Debug.Log ("armor2 = true");
//				armor = 2;
			}
			choiceArmor = true;
		}
	}

	void steedChoice ()
	{
		if (choiceSteed == false) {
			if (this.gameObject.name.Equals ("steed1")) {
				steed1 = true;
			}
			if (this.gameObject.name.Equals ("steed2")) {
				steed2 = true;
			}
			if (this.gameObject.name.Equals ("steed3")) {
				steed3 = true;
			}
			choiceSteed = true;
		}
	}
}


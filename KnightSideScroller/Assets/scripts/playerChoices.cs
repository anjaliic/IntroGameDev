using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerChoices : MonoBehaviour {

	public static playerChoices Choice;

	List<int> choices = new List<int>();

	bool choiceArmor = false;
	public bool armor1;
	public bool armor2;


	void Start()
	{
		Choice = this;
	}

	void Update()
	{
		if (choiceArmor == true && gameObject.tag.Equals ("armor")) {
			Destroy (gameObject);
		}
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		armorChoice ();
	}

	void armorChoice ()
	{
		if (choiceArmor == false)
		{
			gameObject.SetActive (false);

			if (this.gameObject.name.Equals ("armor1")) 
			{
				armor1 = true;
			}
			if (this.gameObject.name.Equals ("armor2")) 
			{
				armor2 = true;
			}
			choiceArmor = true;
		}
	}
}


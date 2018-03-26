using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textController : MonoBehaviour {

	private TextMesh narrate;

	BoxCollider2D t_collider;

	string narration;

	void Start()
	{
		narrate = GetComponent<TextMesh> ();
		narration = narrate.text;

		t_collider = GetComponent<BoxCollider2D> ();

		narrate.text = ("");
//		narrate.font = gameManager.gameMng.narrateFont;
	}

	void Update()
	{
		armorColor ();

		if(this.gameObject.name.Equals("Help_4") && gameManager.gameMng.starterGold.Equals(true))
		{
			narrate.text = ("Good luck!\n You'll need it.");
		}

		if (Input.GetKey (KeyCode.C) && this.gameObject.name.Equals("Bro_3")) //intructions to press C
		{
			narrate.text = ("");
			Destroy (t_collider);
		}
	
		if (Input.GetKey (KeyCode.C) && this.gameObject.name.Equals ("Fr_2"))
		{
			Destroy (t_collider);
			if (gameManager.gameMng.wealth > 1)
			{
				narrate.text = ("Try offering some of your gold.");
			}
			if (gameManager.gameMng.wealth ==1)
			{
				narrate.text = ("I would say offer them some gold, but you have none.");
			}
		}
	}

	void armorColor ()
	{
		if (this.gameObject.name.Equals ("Armor_3")) 
		{
			if (gameManager.gameMng.armor1 == true)
			{
				narrate.text = ("I would've gone with keppel, but alright.");
			}
			if (gameManager.gameMng.armor2 == true) 
			{
				narrate.text = ("I would've gone with rouge, but alright.");
			}
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		narrate.text = (narration);
		statReset ();
	}

	void statReset ()
	{
		if (this.gameObject.name == ("Stat_2")) {
			gameManager.gameMng.strengthBool = true;
		}
		if (this.gameObject.name == ("Stat_3")) {
			gameManager.gameMng.cunningBool = true;
		}
		if (this.gameObject.name == ("Stat_4")) {
			gameManager.gameMng.wealthBool = true;
		}
		if (this.gameObject.name == ("Stat_5")) {
			gameManager.gameMng.repBool = true;
		}
		if (this.gameObject.name == ("Stat_6")) {
			gameManager.gameMng.statReset = true;
		}
	}
}


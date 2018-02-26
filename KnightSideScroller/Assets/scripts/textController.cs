using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textController : MonoBehaviour {

	private TextMesh narrate;

	string narration;

	void Start()
	{
		narrate = GetComponent<TextMesh> ();
		narration = narrate.text;

		narrate.text = ("");
	}

	void Update()
	{
		if (this.gameObject.name.Equals ("Armor_3")) {
			if (gameManager.gameMng.armor1 == true) {
				narrate.text = ("I would've gone with keppel, but alright.");
			}
			if (gameManager.gameMng.armor2 == true) {
				narrate.text = ("I would've gone with rouge, but alright.");
			}
		}
		if(this.gameObject.name.Equals("Help_4") && gameManager.gameMng.choiceItem.Equals(true))
		{
			narrate.text = ("Good luck!\n You'll need it.");
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		narrate.text = (narration);
		if (this.gameObject.name == ("Stat_2"))
		{
			gameManager.gameMng.strengthBool = true;
		}
		if (this.gameObject.name == ("Stat_3"))
		{
			gameManager.gameMng.cunningBool = true;
		}
		if (this.gameObject.name == ("Stat_4"))
		{
			gameManager.gameMng.wealthBool = true;
		}
		if (this.gameObject.name == ("Stat_5"))
		{
			gameManager.gameMng.repBool = true;
		}
		if (this.gameObject.name == ("Stat_6"))
		{
			gameManager.gameMng.statReset = true;
		}
	}
}


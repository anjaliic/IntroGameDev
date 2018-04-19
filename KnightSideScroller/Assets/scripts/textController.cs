using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textController : MonoBehaviour {

	private TextMesh narrate;

	BoxCollider2D t_collider;

	string narration;

	private bool entered =false; //Nina: switch to true when player walks by

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
			
	
//		if (Input.GetKey (KeyCode.C) && this.gameObject.name.Equals ("Fr_2"))
//		{
//			Destroy (t_collider);
//			if (gameManager.gameMng.wealth > 1)
//			{
//				narrate.text = ("Try offering some of your gold.");
//			}
//			if (gameManager.gameMng.wealth ==1)
//			{
//				narrate.text = ("I would say offer them some gold, but you have none.");
//			}
//		}
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
		//Nina: call the textmesh animation, but only if it hasn't been called yet on this
		//text object, so id doesn't keep fading everytime you walk by it
		if (!entered) {
			entered = true;
			narrate.text = (narration);
			narrate.color = new Color (narrate.color.r, narrate.color.g, narrate.color.b, 0f);
			StartCoroutine (animateAlpha (narrate));
			statReset ();
		}

		if(this.gameObject.name == ("Boy_3") )
		{
			choiceController._choice.showQ2 = true;
		}
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

	//Nina: creates the animation for the textmesh fading into the screen
	IEnumerator animateAlpha(TextMesh t){
		for(float i = 0f; i < 10f;i++){
			yield return new WaitForSeconds (.01f + (i / 300f));
			narrate.color = new Color(narrate.color.r, narrate.color.g, narrate.color.b, ((i+1.001f)/10f));
		}
	}
}


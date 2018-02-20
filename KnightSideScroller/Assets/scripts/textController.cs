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
//		if(this.gameObject.transform.parent.name.Equals("Intro"))
//		{
////		intro = narrate.text;
//		narrate.text = ("blahah");
//		}
//		if(this.gameObject.transform.parent.name.Equals("Armor"))
//		{
//			armor = narrate.text;
//		}
		narrate.text = ("");
	}

	void Update()
	{
//		if (this.gameObject.name.Equals ("Armor_3")) {
//			if (playerChoices.Choice.armor1 == true) {
//				narrate.text = ("I would've gone with keppel, but alright.");
//			}
//			if (playerChoices.Choice.armor2 == true) {
//				narrate.text = ("I would've gone with rouge, but alright.");
//			}
//		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		narrate.text = (narration);
//		Narration_Intro (); 
//		Narration_Armor ();
//		if (this.gameObject.name.Equals ("Stat_1") && textManager.textMng.statN1 == true) {
//			narrate.text = ("In order to become a knight, you need to excel in a variety of categories...");
//		}
//		if (this.gameObject.name.Equals ("Stat_2") && textManager.textMng.statN2 == true) {
//			narrate.text = ("speed,");
//			statManager.statMng.speedBool = true;
//		}
//		if (this.gameObject.name.Equals ("Stat_3") && textManager.textMng.statN3 == true) {
//			narrate.text = ("strength,");
//			statManager.statMng.strengthBool = true;
//		}
//		if (this.gameObject.name.Equals ("Stat_4") && textManager.textMng.statN4 == true) {
//			narrate.text = ("skill,");
//			statManager.statMng.skillBool = true;
//		}
//		if (this.gameObject.name.Equals ("Stat_5") && textManager.textMng.statN5 == true) {
//			narrate.text = ("and wealth.");
//			statManager.statMng.coinBool = true;
//		}
//		if (this.gameObject.name.Equals ("Stat_5") && textManager.textMng.statN5 == true) {
//			narrate.text = ("and wealth.");
//		}
//		if (this.gameObject.name.Equals ("Stat_6") && textManager.textMng.statN6 == true) {
//			narrate.text = ("Unfortunately, you have none of these.");
//			statManager.statMng.statReset = true;
//		}
//		textManager.textMng.introN1 = false;
//		textManager.textMng.introN2 = false;
	}

	void Narration_Intro ()
	{
//		narrate.text = (intro);
//		if (this.gameObject.name.Equals ("Intro_1") && textManager.textMng.introN1 == true) {
//			narrate.text = (intro);
//		}
//		if (this.gameObject.name.Equals ("Intro_2") && textManager.textMng.introN2 == true) {
//			narrate.text = ("...or at least, you aspire to be.");
//		}
//		if (this.gameObject.name.Equals ("Intro_3") && textManager.textMng.introN3 == true) {
//			narrate.text = ("The road to knighthood is not easy...");
//		}
//		if (this.gameObject.name.Equals ("Intro_4") && textManager.textMng.introN4 == true) {
//			narrate.text = ("...but I can help you get started.");
//		}
	}

	void Narration_Armor ()
	{
//		narrate.text = armor;
//		if (this.gameObject.name.Equals ("Armor_1") && textManager.textMng.armorN1 == true) {
//			narrate.text = ("To start, you should definitely ditch that armor.");
//		}
//		if (this.gameObject.name.Equals ("Armor_2") && textManager.textMng.armorN2 == true) {
//			narrate.text = ("Silver is way overdone.");
//		}
//		if (this.gameObject.name.Equals ("Armor_3") && textManager.textMng.armorN3 == true) {
//			narrate.text = ("A rouge or keppel, perhaps?");
//		}
	}
}


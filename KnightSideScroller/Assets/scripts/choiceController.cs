using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class choiceController : MonoBehaviour {

	public static choiceController _choice;

	public AudioClip collectItem;

	SpriteRenderer choiceRend;

	BoxCollider2D choiceColl;

	Scene currentScene;
	string sceneName;

	public Sprite choice;

	bool showQ1;
	bool showGift;
	//bool showQ1 in gameMng 
	//bool showQ3 in gameMng // Yes / No
	//showQ4_1
	//bool showQ4_2

	List<string> Hide = new List<string> {"Question", "Gift", "Question2", "Question3", "Question4_1","Question4_2", "Enemy", "Enemy2"};

	void Start () 
	{
		currentScene = SceneManager.GetActiveScene ();
		sceneName = currentScene.name;
		choiceColl = GetComponent<BoxCollider2D> ();
		choiceRend = GetComponent<SpriteRenderer> ();
		_choice = this;

		if(Hide.Contains(this.gameObject.transform.parent.name))
		{
			choiceRend.color = new Color(255,255,255,0);
		}
	}

	void Update()
	{
		Scene2Mission ();
		Scene3River ();
	
		if (gameManager.gameMng.showEnemy == true && this.gameObject.transform.parent.name == ("Enemy"))
		{
			choiceRend.color = new Color (255, 255, 255, 255);
			if (this.gameObject.name == ("enemy1")) {
				choiceColl.size = new Vector2 (1f, 1f);
			}
			if (this.gameObject.name == ("enemy2")) {
				choiceColl.size = new Vector2 (5f, 2f);
			}
		} else if (gameManager.gameMng.showEnemy == false && this.gameObject.transform.parent.name == ("Enemy"))
		{
			choiceRend.color = new Color (255, 255, 255, 0);
			choiceColl.size = new Vector2 (0f, 0f);
		}

		if (gameManager.gameMng.showEnemy2 == true && this.gameObject.transform.parent.name == ("Enemy2"))
		{
			choiceRend.color = new Color (255, 255, 255, 255);
			choiceColl.size = new Vector2 (6f, 1f);
		} else if (gameManager.gameMng.showEnemy2 == false && this.gameObject.transform.parent.name == ("Enemy2"))
		{
			choiceRend.color = new Color (255, 255, 255, 0);
			choiceColl.size = new Vector2 (0f, 0f);
		}
	}

	void Scene2Mission ()
	{
		//Controls when question 1 is visible/interactable
		if (this.gameObject.transform.parent.name == ("Question") && sceneName == ("scene_2"))
		{
			if (dialogueController.dialogueCtrl.d3bool == true) 
			{
				dialogueController.dialogueCtrl.contDialogue = false;
				showQ1 = true;
			}
			if (showQ1 == true) 
			{
				choiceRend.color = new Color (255, 255, 255, 255);
				choiceColl.size = new Vector2 (4.5f, 2.25f);
			}
			else
				if (showQ1 == false)
				{
					choiceRend.color = new Color (255, 255, 255, 0);
					choiceColl.size = new Vector2 (0f, 0f);
				}
		}


		//Controls when gift is visible/interactable
		if (this.gameObject.transform.parent.name == ("Gift") && sceneName == ("scene_2"))
		{
			if(dialogueController.dialogueCtrl.d8bool == true)
			{
				showGift = true;
			}
			if(showGift == true)
			{
				choiceRend.color = new Color (255,255,255,255);
			}
		}
	}

	void Scene3River ()
	{
		if (this.gameObject.transform.parent.name == ("Question2") && sceneName == ("river")) {
			if (gameManager.gameMng.showQ2 == true) {
				choiceRend.color = new Color (255, 255, 255, 255);
				choiceColl.size = new Vector2 (5f, 2.25f);
			}
			else
				if (showQ1 == false) {
					choiceRend.color = new Color (255, 255, 255, 0);
					choiceColl.size = new Vector2 (0f, 0f);
				}
		}
		if (this.gameObject.transform.parent.name == ("Question3") && sceneName == ("river")) {
			if (gameManager.gameMng.showQ3 == true) {
				choiceRend.color = new Color (255, 255, 255, 255);
				choiceColl.size = new Vector2 (2f, 2f);
			}
			else
				if (gameManager.gameMng.showQ3 == false) {
					choiceRend.color = new Color (255, 255, 255, 0);
					choiceColl.size = new Vector2 (0f, 0f);
				}
		}
		if (this.gameObject.transform.parent.name == ("Question4_1") && sceneName == ("river")) {
			if (gameManager.gameMng.showQ4_1 == true) {
				choiceRend.color = new Color (255, 255, 255, 255);
				choiceColl.size = new Vector2 (5f, 1f);
			}
			else
				if (gameManager.gameMng.showQ4_1 == false) {
					choiceRend.color = new Color (255, 255, 255, 0);
					choiceColl.size = new Vector2 (0f, 0f);
				}
		}
		if (this.gameObject.transform.parent.name == ("Question4_2") && sceneName == ("river")) {
			if (gameManager.gameMng.showQ4_2 == true) {
				choiceRend.color = new Color (255, 255, 255, 255);
				choiceColl.size = new Vector2 (5f, 1f);
			}
			else
				if (gameManager.gameMng.showQ4_2 == false) {
					choiceRend.color = new Color (255, 255, 255, 0);
					choiceColl.size = new Vector2 (0f, 0f);
				}
		}
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		armorChoice ();
		StarterGold ();

		q1Choice ();
		giftChoice ();

		q2Choice ();
		q3Choice ();
		q4Choice ();

		searchChoice ();

		if (gameManager.gameMng.choiceEnemy == false && this.gameObject.transform.parent.name == ("Enemy"))
		{
			this.gameObject.SetActive (false);
			if (this.gameObject.name.Equals ("enemy1"))	//give gold
			{
				gameManager.gameMng.enemy1 = true;
				dialogueController.dialogueCtrl.d2b = true;
				dialogue2Controller.dialogueCtrl2.d2b_2 = true;
				gameManager.gameMng.wealth--; //lose one gold

			}
			if (this.gameObject.name.Equals ("enemy2"))	//use your words
			{
				gameManager.gameMng.enemy2 = true;
				dialogueController.dialogueCtrl.d3b = true;
				dialogue2Controller.dialogueCtrl2.d3b_2 = true;
				gameManager.gameMng.showEnemy2 = true;
			}
			gameManager.gameMng.choiceEnemy = true;
			gameManager.gameMng.showEnemy = false;
		}

		if (gameManager.gameMng.enemy2 == true && this.gameObject.transform.parent.name == ("Enemy2"))
		{
			this.gameObject.SetActive(false);
			if(this.gameObject.name == ("enemy1"))
			{
				if (gameManager.gameMng.cunning >= 2) 
				{
					dialogueController.dialogueCtrl.d4b = true;
					dialogue2Controller.dialogueCtrl2.d4b_2 = true;
					gameManager.gameMng.rep++;
				} else if (gameManager.gameMng.cunning < 2)
				{
					dialogueController.dialogueCtrl.d5b = true;
					dialogue2Controller.dialogueCtrl2.d5b_2 = true;
					gameManager.gameMng.wealth = gameManager.gameMng.wealth - 2;
				}
			}
			if(this.gameObject.name == ("enemy2"))
			{
				if (gameManager.gameMng.strength >= 2)
				{
					dialogueController.dialogueCtrl.d6b = true;
					dialogue2Controller.dialogueCtrl2.d6b_2 = true;
					gameManager.gameMng.rep++;
				} else if (gameManager.gameMng.strength < 2)
				{
					dialogueController.dialogueCtrl.d7b = true;
					dialogue2Controller.dialogueCtrl2.d7b_2 = true;
					gameManager.gameMng.wealth = gameManager.gameMng.wealth - 2;
				}
			}
			gameManager.gameMng.showEnemy2 = false;
			gameManager.gameMng.choiceEnemy2 = true;
		}

	}

	void armorChoice ()
	{
		if (gameManager.gameMng.choiceArmor == false && this.gameObject.transform.parent.name.Equals("Armor")) 
		{
			this.gameObject.SetActive (false);
			if (this.gameObject.name.Equals ("armor1"))
			{
				//Nina: Play a sound using the scenes soundmanager
				soundManager.playSound (collectItem);
//				choiceAudio.PlayOneShot(1);
				gameManager.gameMng.armor1 = true;
			}
			if (this.gameObject.name.Equals ("armor2"))
			{
//				choiceAudio.PlayOneShot (1);
				//Nina: Play a sound using the scenes soundmanager
				soundManager.playSound (collectItem);
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
				gameManager.gameMng.wealth = gameManager.gameMng.wealth + 1;
				//Nina: Play a sound using the scenes soundmanager
				soundManager.playSound (collectItem);
			}
			gameManager.gameMng.starterGold = true;
		}
	}

	void q1Choice ()
	{
		if (gameManager.gameMng.choiceQ1 == false && this.gameObject.transform.parent.name == ("Question")) 
		{
			this.gameObject.SetActive (false);
			if (this.gameObject.name == ("q1")) {
				dialogueController.dialogueCtrl.d5b = true;
				gameManager.gameMng.q1_1 = true;
			}
			if (this.gameObject.name == ("q2")) {
				dialogueController.dialogueCtrl.d4b = true;
				gameManager.gameMng.q1_2 = true;
			}
			showQ1 = false;
			gameManager.gameMng.choiceQ1 = true;
		}
	}

	void giftChoice ()
	{
		if (gameManager.gameMng.choiceGift == false && this.gameObject.transform.parent.name.Equals ("Gift"))
		{
			this.gameObject.SetActive (false);
			if (this.gameObject.name.Equals ("g1"))
			{
				gameManager.gameMng.gift1 = true;
				gameManager.gameMng.strength++;
			}
			if (this.gameObject.name.Equals ("g2"))
			{
				gameManager.gameMng.gift2 = true;
				gameManager.gameMng.cunning++;
			}
			if (this.gameObject.name.Equals ("g3"))
			{
				gameManager.gameMng.gift3 = true;
				gameManager.gameMng.wealth++;
			}
			gameManager.gameMng.choiceGift = true;
		}
	}

	void q2Choice ()
	{
		if (gameManager.gameMng.choiceQ2 == false && this.gameObject.transform.parent.name == ("Question2")) 
		{
			this.gameObject.SetActive (false);
			if (this.gameObject.name == ("q1")) //have you seen a boy?
			{
				dialogueController.dialogueCtrl.d1b = true; //he was here before
				gameManager.gameMng.askDog = true;
				gameManager.gameMng.q2_2 = true;
			}
			if (this.gameObject.name == ("q2"))	//your brother is looking for you
			{
				dialogueController.dialogueCtrl.d2b = true; //i dont have a brother
				gameManager.gameMng.q2_2 = true;
			}
			gameManager.gameMng.showQ2 = false;
			gameManager.gameMng.choiceQ2 = true;
			dialogueController.dialogueCtrl.contDialogue = false;
			areaController.areaCtrl.A3_2 = true;
		}
	}

	void q3Choice ()
	{
		if (gameManager.gameMng.choiceQ3 == false && this.gameObject.transform.parent.name == ("Question3"))
		{
			Debug.Log ("test test test");
			this.gameObject.SetActive (false);
			if (this.gameObject.name == ("q1"))	//yes
			{
				dialogueController.dialogueCtrl.d4b = true;	//i wanna be a knight someday
				gameManager.gameMng.q3_2 = true;
				gameManager.gameMng.showQ4_1 = true;
			}
			if (this.gameObject.name == ("q2"))	//no
			{
				dialogueController.dialogueCtrl.d7b = true;	//then why are you dressed like that?
				gameManager.gameMng.q3_2 = true;
				gameManager.gameMng.showQ4_2 = true;
			}
			gameManager.gameMng.showQ3 = false;
			gameManager.gameMng.choiceQ3 = true;
		}
	}

	void q4Choice ()
	{
		if (gameManager.gameMng.choiceQ4 == false && this.gameObject.transform.parent.name == ("Question4_1"))
		{
			this.gameObject.SetActive (false);
			if (this.gameObject.name == ("q1")) {	//keep dreaming
				gameManager.gameMng.q4_1_1 = true;
				dialogueController.dialogueCtrl.d5b = true;	//thats what my mom always says
			}
			if (this.gameObject.name == ("q2")) {	//never give up on your dreams
				gameManager.gameMng.q4_1_2 = true;
				dialogueController.dialogueCtrl.d6b = true;	//i wont!
				gameManager.gameMng.rep++;
				gameManager.gameMng.nice = true;
			}
			gameManager.gameMng.showQ4_1 = false;
			gameManager.gameMng.choiceQ4 = true;

		}

		if (gameManager.gameMng.choiceQ4 == false && this.gameObject.transform.parent.name == ("Question4_2")) 
		{
			this.gameObject.SetActive (false);
			gameManager.gameMng.q4_2 = true;
			dialogueController.dialogueCtrl.d8b = true;
			gameManager.gameMng.showQ4_2 = false;
			gameManager.gameMng.choiceQ4 = true;
			gameManager.gameMng.nice = true;
		}
}

	void searchChoice ()
	{
		if (gameManager.gameMng.choiceSearch == false && this.gameObject.transform.parent.name.Equals ("Search"))
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
			gameManager.gameMng.choiceArmor = true;
		}
	}
}


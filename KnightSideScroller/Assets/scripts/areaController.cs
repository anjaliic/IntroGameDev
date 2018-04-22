using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//blocks player from progressing without reading all of the character dialogue (still working on it)

public class areaController : MonoBehaviour {

	public static areaController areaCtrl;

//	public bool A1 = true;

	BoxCollider2D areaCollider;

	Scene currentScene;
	string sceneName;

	public bool A3_2; //Areas_3

	void Start () 
	{
		currentScene = SceneManager.GetActiveScene ();
		sceneName = currentScene.name;

		areaCtrl = this;
		areaCollider = GetComponent<BoxCollider2D> ();
	}

	void Update () 
	{
		Scene2MissionUpdate ();
		Scene3River ();

		if (sceneName == ("scene_3fr") && this.gameObject.transform.parent.name == ("Areas_4"))
		{
			if (gameManager.gameMng.troll1 == true)
			{
				if (this.gameObject.name == ("A_3"))
				{
					Destroy (gameObject);
				}
			}
		}
	}

	void Scene2MissionUpdate ()
	{
		if (sceneName == ("scene_2") && this.gameObject.transform.parent.name == ("Areas_2")) 
		{
			if (gameManager.gameMng.choiceQ1 == true) 
			{
				if (this.gameObject.name == ("A_1"))
				{
					Destroy (gameObject);
				}
				if (this.gameObject.name == ("A_2") && dialogueController.dialogueCtrl.d8bool == true) 
				{
					Destroy (gameObject);
				}
			}
		}
	}

	void Scene3River ()
	{
		if (sceneName == ("river") && this.gameObject.transform.parent.name == ("Areas_3"))
		{
			if (gameManager.gameMng.choiceQ2 == true) 
			{
				if (this.gameObject.name == ("A_1"))
				{
					Destroy (gameObject);
				}
			}
		}
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		Scene2MissionColl ();
		Scene3RiverColl ();

	}

	void Scene2MissionColl ()
	{
		if (this.gameObject.transform.parent.name == ("Areas_2")) 
		{
			if (this.gameObject.name == ("A_2"))
			{
				dialogueController.dialogueCtrl.d6b = true;
				dialogueController.dialogueCtrl.contDialogue = true;
			}
		}
	}

	void Scene3RiverColl ()
	{
		if (this.gameObject.transform.parent.name == ("Areas_3"))
		{
			if (this.gameObject.name == ("A_2")) 
			{
				if (A3_2 == true)
				{
					dialogueController.dialogueCtrl.d3b = true;
					//are you a knight?
					gameManager.gameMng.showQ3 = true;
					A3_2 = false;
				}
				if (gameManager.gameMng.choiceQ4 == true)
				{
					Destroy (gameObject);
				}
			}
		}
	}

	void OnTriggerEnter2D(Collider2D coll)
	{
		if (this.gameObject.transform.parent.name == ("Areas_4"))
		{
			if(this.gameObject.name == ("A_1"))
			{
				dialogueController.dialogueCtrl.contDialogue = false;
				Debug.Log("show troll dialogue 1");
				dialogueController.dialogueCtrl.d1b = true;
			}
			if(this.gameObject.name == ("A_2"))
			{
				dialogue2Controller.dialogueCtrl2.d1b_2 = true;
			}
		}
	}
}

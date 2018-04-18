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

	void Start () 
	{
		currentScene = SceneManager.GetActiveScene ();
		sceneName = currentScene.name;

		areaCtrl = this;
		areaCollider = GetComponent<BoxCollider2D> ();
	}

	void Update () 
	{
		if (sceneName == ("scene_2") && this.gameObject.transform.parent.name == ("Areas_2"))
		{
			Debug.Log ("find scene/area parent");
			if(gameManager.gameMng.choiceQ1 == true)
			{
				Debug.Log ("asked question");

				if(this.gameObject.name == ("A_1"))
					{
						Destroy (gameObject);
					}
				if(this.gameObject.name == ("A_2") && dialogueController.dialogueCtrl.d8bool == true)
				{
					Destroy (gameObject);
				}
			}
		}
	}

	void OnCollisionEnter2D(Collision2D coll)
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
}

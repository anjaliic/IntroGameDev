using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneController : MonoBehaviour {

	Scene start;
	Scene scene_2;

	void Start()
	{
		start = SceneManager.GetSceneByName ("game_start");
		scene_2 = SceneManager.GetSceneByName ("scene_2");
	}
	void OnTriggerEnter2D(Collider2D player){

		if(this.gameObject.name == ("ST_1"))
		{
			SceneManager.LoadScene ("scene_2", LoadSceneMode.Single);
			SceneManager.SetActiveScene (scene_2);
		}

		if (this.gameObject.name == ("ST_2"))
		{

		}

	}
}

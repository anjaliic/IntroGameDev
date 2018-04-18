using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneController : MonoBehaviour {

	Scene start;
	Scene scene_2;
	Scene river;
	Scene scene_3fr;
	Scene scene_3mt;

	void Start()
	{
		start = SceneManager.GetSceneByName ("game_start");
		scene_2 = SceneManager.GetSceneByName ("scene_2");
		river = SceneManager.GetSceneByName ("river");
		scene_3fr = SceneManager.GetSceneByName ("scene_3_forest");
		scene_3mt = SceneManager.GetSceneByName ("scene_3_mt");
	}
	void OnTriggerEnter2D(Collider2D player){

		if(this.gameObject.name == ("ST_1"))
		{
			SceneManager.LoadScene ("scene_2", LoadSceneMode.Single);
			SceneManager.SetActiveScene (scene_2);
		}

		if (this.gameObject.name == ("ST_2")) {
			SceneManager.LoadScene ("river", LoadSceneMode.Single);
			SceneManager.SetActiveScene (river);
		}

//		if (this.gameObject.name == ("ST_2"))
//		{
//			if (gameManager.gameMng.search1 == true)
//			{
//				SceneManager.LoadScene ("scene_3_forest", LoadSceneMode.Single);
//				SceneManager.SetActiveScene (scene_3fr);
//			}
//			if (gameManager.gameMng.search2 == true)
//			{
//				SceneManager.LoadScene ("scene_3_mt", LoadSceneMode.Single);
//				SceneManager.SetActiveScene (scene_3mt);
//			}
//		}

	}
}

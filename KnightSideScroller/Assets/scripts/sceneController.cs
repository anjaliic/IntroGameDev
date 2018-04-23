using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneController : MonoBehaviour {

	public static sceneController sceneCtrl;

	public bool cavemusic;

	Scene start;
	Scene scene_2;
	Scene river;
	Scene scene_3fr;
	Scene scene_3mt;
	Scene caves;
	Scene monster;
	Scene end;
	Scene end2;

	void Start()
	{
		sceneCtrl = this;

		start = SceneManager.GetSceneByName ("game_start");
		scene_2 = SceneManager.GetSceneByName ("scene_2");
		river = SceneManager.GetSceneByName ("river");
		scene_3fr = SceneManager.GetSceneByName ("scene_3_fr");
		scene_3mt = SceneManager.GetSceneByName ("scene_3_mt");
		caves = SceneManager.GetSceneByName ("caves");
		monster = SceneManager.GetSceneByName ("monster");
		end = SceneManager.GetSceneByName("end");
		end2 = SceneManager.GetSceneByName ("end2");
	}

	void OnTriggerEnter2D(Collider2D player)
	{
		if (this.gameObject.name == ("start"))
		{
			SceneManager.LoadScene ("game_start", LoadSceneMode.Single);
			SceneManager.SetActiveScene (start);
		}

		if(this.gameObject.name == ("ST_1"))
		{
			SceneManager.LoadScene ("scene_2", LoadSceneMode.Single);
			SceneManager.SetActiveScene (scene_2);
		}

		if (this.gameObject.name == ("ST_2")) {
			SceneManager.LoadScene ("river", LoadSceneMode.Single);
			SceneManager.SetActiveScene (river);
		}

		if (this.gameObject.name == ("ST_3")) 
		{
			SceneManager.LoadScene ("scene_3fr", LoadSceneMode.Single);
			SceneManager.SetActiveScene (scene_3fr);
		}

//		if (this.gameObject.name == ("ST_3") && gameManager.gameMng.search2 == true) 
//		{
//			SceneManager.LoadScene ("scene_3_mt", LoadSceneMode.Single);
//			SceneManager.SetActiveScene (scene_3mt);
//		}

		if(this.gameObject.name == ("ST_4"))
		{
			cavemusic = true;
			SceneManager.LoadScene ("caves", LoadSceneMode.Single);
			SceneManager.SetActiveScene (caves);
		}

		if (this.gameObject.name == ("ST_5"))
		{
			SceneManager.LoadScene ("monster", LoadSceneMode.Single);
			SceneManager.SetActiveScene (monster);
		}

		if (this.gameObject.name == ("ST_6"))
		{
			cavemusic = false;
			if (gameManager.gameMng.rep >= 1)
			{
				SceneManager.LoadScene ("end", LoadSceneMode.Single);
				SceneManager.SetActiveScene (end);
			}
			else if (gameManager.gameMng.rep < 1)
			{
				SceneManager.LoadScene ("end2",LoadSceneMode.Single);
				SceneManager.SetActiveScene (end2);
			}
		}
	}
}

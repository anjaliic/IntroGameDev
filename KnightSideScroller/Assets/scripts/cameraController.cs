using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour {

	public GameObject Player;

	public float speed = 2.0f;

	void Start()
	{
		Player = GameObject.FindWithTag ("Player");
	}

	void Update () {

		float interpolation = speed * Time.deltaTime;

		Vector3 position = this.transform.position;
	
		position.x = Mathf.Lerp (this.transform.position.x, Player.transform.position.x, interpolation);

		this.transform.position = position;
	}


}

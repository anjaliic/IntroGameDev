﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

	public static playerController playerCtrl;

	public Sprite startingSprite;
	public Sprite playerarmor1;
	public Sprite playerarmor2;

	SpriteRenderer spriteRend;

	//for cameraController
//	public float xpos = GameObject.Find("Player").transform.position.x;

	//player walk
	public float playerSpeed;
	public float jumpSpeed;

	//player jump
	public Vector2 speed = new Vector2(10,10);
	private Vector2 movement = new Vector2 (1,1);

	void Start()
	{
		playerCtrl = this;

		spriteRend = GetComponent<SpriteRenderer> ();
		spriteRend.sprite = startingSprite;
	}

	void Update () 
	{	
		if (playerChoices.Choice.armor1.Equals (true))
		{
			Debug.Log ("player is armor1");
			spriteRend.sprite = playerarmor1;
		}
		if (playerChoices.Choice.armor2.Equals (true))
		{
			spriteRend.sprite = playerarmor2;
			Debug.Log ("player is armor2");
		}
		PlayerWalk ();
		PlayerJump ();
	}

	void PlayerWalk ()
	{
		if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) {
			transform.position += transform.right * playerSpeed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) {
			transform.position += transform.right * -playerSpeed * Time.deltaTime;
		}
	}

	void PlayerJump ()
	{
		float inputX = Input.GetAxis ("Horizontal");
		float inputY = Input.GetAxis ("Vertical");

		movement = new Vector2 (speed.x * inputX, speed.y * inputY);

		if (Input.GetKeyDown (KeyCode.Space) || Input.GetKeyDown (KeyCode.W) || Input.GetKeyDown (KeyCode.UpArrow)) {
			transform.Translate (Vector3.up * jumpSpeed* Time.deltaTime, Space.World);
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

	public static playerController playerCtrl;

//	public GameObject Player;

	public Rigidbody2D playerRB;

	public Sprite startingSprite;
	public Sprite playerarmor1;
	public Sprite playerarmor2;

	public SpriteRenderer spriteRend;

	public float jumpSpeed;

	public float playerSpeed;

	public bool isFalling;

	void Start()
	{
		playerCtrl = this;

		playerRB = GetComponent<Rigidbody2D> ();

		spriteRend = GetComponent<SpriteRenderer> ();
		spriteRend.sprite = startingSprite;
	}

	void OnCollisionStay2D(Collision2D coll)
	{
		isFalling = false;
	}

	void Update () 
	{	
		//movement controls
		PlayerWalk ();
		PlayerJump ();

		playerArmor ();	//choice1
	}

	void PlayerWalk ()
	{
		if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow))
		{
			transform.position += transform.right * playerSpeed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) 
		{
			transform.position += transform.right * -playerSpeed * Time.deltaTime;
		}
	}

	void PlayerJump ()
	{
		if (!isFalling && (Input.GetKeyDown (KeyCode.Space) || Input.GetKeyDown (KeyCode.W) || Input.GetKeyDown (KeyCode.UpArrow)))
		{
			playerRB.velocity = new Vector3 (0f,jumpSpeed,0f);
			Debug.Log ("jump");
			isFalling = true;
		}
	}

	void playerArmor ()
	{
		if (gameManager.gameMng.choiceArmor.Equals (true))
		{
			if (gameManager.gameMng.armor1.Equals (true))
			{
				Debug.Log ("player = armor1");
				spriteRend.sprite = playerarmor1;
			}

			if (gameManager.gameMng.armor2.Equals (true))
			{
				Debug.Log ("player = armor2");
				spriteRend.sprite = playerarmor2;
			}
		}
	}
}

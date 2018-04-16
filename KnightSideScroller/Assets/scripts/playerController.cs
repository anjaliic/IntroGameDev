using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

	public static playerController playerCtrl;

	AudioSource walkAudio;
	AudioSource otherAudio;
	public AudioClip jumpSound;

	public Rigidbody2D playerRB;


	public Sprite startingSprite;
	public Sprite playerarmor1;
	public Sprite playerarmor2;

	public SpriteRenderer spriteRend;

	public float jumpSpeed;

	public float playerSpeed;

	public bool isWalking;
	public bool isFalling;

	AudioSource[] audioSources;

	//Nina: the particle system for when the player jumps
	public GameObject groundParticleSystem;
	//Nina: the particle system for when the player hits a collectable object
	public GameObject starParticle;

	void Start()
	{
		audioSources = GetComponents<AudioSource> ();
		walkAudio = audioSources [0];
		otherAudio = audioSources [1];

		playerCtrl = this;

		playerRB = GetComponent<Rigidbody2D> ();

		spriteRend = GetComponent<SpriteRenderer> ();
		spriteRend.sprite = startingSprite;
	}

	void OnCollisionStay2D(Collision2D coll)
	{
		isFalling = false;
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		//Nina: check if walking because there are multiple colliders and it triggers while the person
		//walks across them
		if (coll.gameObject.name.Contains ("ground") && !isWalking) {
			//Nina: create the particle system 
			Vector2 vec2 = new Vector2(gameObject.transform.position.x, -4.29f);
			GameObject p = Instantiate (groundParticleSystem, vec2, Quaternion.identity);

			//Nina: destroy the particle system after its done emitting so there's not just a bunch
			//of particle systems sitting around on the screen after a long time
			StartCoroutine(destroyObject(p,2f));
		}

		if (coll.gameObject.name.Contains ("armor") || coll.gameObject.name.Contains ("gold")) {
			Vector2 vec2 = new Vector2(gameObject.transform.position.x + 2f, gameObject.transform.position.y + 2f);
			GameObject s = Instantiate (starParticle, vec2, Quaternion.identity);
			StartCoroutine(destroyObject(s,2f));
			
		}
	}

	void Update () 
	{	
		if (isFalling == false && isWalking == false) {
			walkAudio.mute = true;
		} else
		{
			walkAudio.mute = false;
		}

		//movement controls
		PlayerWalk ();
		PlayerJump ();

		playerArmor ();	//choice1
	}

	void PlayerWalk ()
	{
		if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow))
		{
			isWalking = true;
			spriteRend.flipX = false;
			transform.position += transform.right * playerSpeed * Time.deltaTime;
		} 
		if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow))
		{
			isWalking = true;
			spriteRend.flipX = true;
			transform.position += transform.right * -playerSpeed * Time.deltaTime;
		} 
		if (!Input.GetKey (KeyCode.D) && !Input.GetKey (KeyCode.RightArrow) && !Input.GetKey (KeyCode.A) && !Input.GetKey (KeyCode.LeftArrow))
		{
			isWalking = false;
		}
	}

	void PlayerJump ()
	{
		if (!isFalling && (Input.GetKeyDown (KeyCode.Space) || Input.GetKeyDown (KeyCode.W) || Input.GetKeyDown (KeyCode.UpArrow))) {
			playerRB.velocity = new Vector3 (0f, jumpSpeed, 0f);
			Debug.Log ("jump");
			otherAudio.PlayOneShot (jumpSound);

			//Nina: create the particle system ; -4.29 is the height of the ground
			Vector2 vec2 = new Vector2(gameObject.		transform.position.x, -4.29f);
			GameObject p = Instantiate (groundParticleSystem, vec2, Quaternion.identity);

			//Nina: destroy the particle system after its done emitting so there's not just a bunch
			//of particle systems sitting around on the screen after a long time
			StartCoroutine(destroyObject(p,2f));

			isFalling = true;
		}
	}

	//changes armor color 
	void playerArmor ()
	{
		if (gameManager.gameMng.choiceArmor.Equals (true))
		{
			if (gameManager.gameMng.armor1.Equals (true))
			{
				Debug.Log ("player = armor1");
				spriteRend.sprite = playerarmor1;
				gameManager.gameMng.choiceArmor.Equals (false);
			}

			if (gameManager.gameMng.armor2.Equals (true))
			{
				Debug.Log ("player = armor2");
				spriteRend.sprite = playerarmor2;
				gameManager.gameMng.choiceArmor.Equals (false);
			}
		}
	}

	//Nina: IEnumerator to destroy an object after a certain period of time
	IEnumerator destroyObject(GameObject g, float time){
		yield return new WaitForSeconds (time);
		Destroy (g.gameObject);
	}
}

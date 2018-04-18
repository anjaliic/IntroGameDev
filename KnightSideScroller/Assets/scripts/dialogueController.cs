using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogueController : MonoBehaviour {

	//controls dialogue from characters (not narrator)

	public static dialogueController dialogueCtrl;

	public SpriteRenderer speechRend;
	public Sprite invis;
	public Sprite d1;
	public Sprite d2;
	public Sprite d3;
	public Sprite d4;
	public Sprite d5;
	public Sprite d6;
	public Sprite d7;
	public Sprite d8;

	public bool d1bool;
	public bool d2bool;
	public bool d3bool;
	public bool d4bool;
	public bool d5bool;
	public bool d6bool;
	public bool d7bool;
	public bool d8bool;


	public bool contDialogue = true;

	//bools to directly change dialogue outside of this script
	public bool d1b;
	public bool d2b;
	public bool d3b;
	public bool d4b;
	public bool d5b;
	public bool d6b;
	public bool d7b;
	public bool d8b;

	public bool resetBoolOverride;

	BoxCollider2D d_collider;

	void Start()
	{
		dialogueCtrl = this;
		speechRend = GetComponent<SpriteRenderer> ();
		speechRend.sprite = invis;
		d_collider = GetComponent<BoxCollider2D> ();
	}

	void Update()
	{
		BoolOverride ();

//		if (resetBoolOverride == true) {
//			bool d1b = false;
//			bool d2b = false;
//			bool d3b = false;
//			bool d4b = false;
//			bool d5b = false;
//			bool d6b = false;
//			bool d7b = false;
//			bool d8b = false;
//			resetBoolOverride = false;
//		}

		if (speechRend.sprite == d1 && Input.GetKeyDown(KeyCode.E) && this.gameObject.tag.Equals("convo") && contDialogue == true)
		{
			speechRend.sprite = d2;
			d1bool = false;
			d2b = false;
			d2bool = true;
		}
		else if (Input.GetKeyDown(KeyCode.E) && this.gameObject.tag.Equals("convo") && contDialogue == true && speechRend.sprite == d2)
		{
			speechRend.sprite = d3;
			d2bool = false;
			d3b = false;
			d3bool = true;
		}
		else if (Input.GetKeyDown(KeyCode.E) && this.gameObject.tag.Equals("convo") && contDialogue == true && speechRend.sprite == d3)
		{
			speechRend.sprite = d4;
			d3bool = false;
			d4b = false;
			d4bool = true;
		}
		else if (Input.GetKeyDown(KeyCode.E) && this.gameObject.tag.Equals("convo") && contDialogue == true && speechRend.sprite == d4)
		{
			speechRend.sprite = d5;
			d4bool = false;
			d5b = false;
			d5bool = true;
		}
		else if (Input.GetKeyDown(KeyCode.E) && this.gameObject.tag.Equals("convo") && contDialogue == true && speechRend.sprite == d5)
		{
			speechRend.sprite = d6;
			d5bool = false;
			d6b = false;
			d6bool = true;
		}
		else if (Input.GetKeyDown(KeyCode.E) && this.gameObject.tag.Equals("convo") && contDialogue == true && speechRend.sprite == d6)
		{
			speechRend.sprite = d7;
			d6bool = false;
			d7b = false;
			d7bool = true;
		}		
		else if (Input.GetKeyDown(KeyCode.E) && this.gameObject.tag.Equals("convo") && contDialogue == true && speechRend.sprite == d7)
		{
			speechRend.sprite = d8;
			d7bool = false;
			d8b = false;
			d8bool = true;
		}
			
	}

	void BoolOverride ()
	{
		if (d1b == true) {
			speechRend.sprite = d1;
			d1b = false;
//			d1bool = true;
		}
		if (d2b == true) {
			speechRend.sprite = d2;
			d1bool = false;
			d2b = false;
//			d2bool = true;
		}
		if (d3b == true) {
			speechRend.sprite = d3;
			d1bool = false;
			d2bool = false;
			d3b = false;
//			d3bool = true;
		}
		if (d4b == true) {
			speechRend.sprite = d4;
			d1bool = false;
			d2bool = false;
			d3bool = false;
			d4b = false;
//			d4bool = true;
		}
		if (d5b == true) {
			speechRend.sprite = d5;
			d1bool = false;
			d2bool = false;
			d3bool = false;
			d4bool = false;
			d5b = false;
//			d5bool = true;
		}
		if (d6b == true) {
			speechRend.sprite = d6;

			d1bool = false;
			d2bool = false;
			d3bool = false;
			d4bool = false;
			d5bool = false;
			d6b = false;
//			d6bool = true;
		}
		if (d7b == true) {
			speechRend.sprite = d7;
			d1bool = false;
			d2bool = false;
			d3bool = false;
			d4bool = false;
			d5bool = false;
			d6bool = false;
			d7b = false;
//			d7bool = true;
		}
		if (d8b == true) {
			speechRend.sprite = d8;
			d1bool = false;
			d2bool = false;
			d3bool = false;
			d4bool = false;
			d5bool = false;
			d6bool = false;
			d7bool = false;
			d8b = false;
//			d8bool = true;
		}
	}

	void OnTriggerEnter2D(Collider2D speech)
	{
		speechRend.sprite = d1;
		d8bool = false;
		d1bool = true;
		d1b = false;
		Debug.Log ("dialogue is visible");
		Destroy (this.d_collider);
	}
}

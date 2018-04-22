using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogue2Controller : MonoBehaviour {

	public static dialogue2Controller dialogueCtrl2;

	public SpriteRenderer speechRend2;
	public Sprite invis2;
	public Sprite d1_2;
	public Sprite d2_2;
	public Sprite d3_2;
	public Sprite d4_2;
	public Sprite d5_2;
	public Sprite d6_2;
	public Sprite d7_2;
	public Sprite d8_2;

	public bool d1b_2;
	public bool d2b_2;
	public bool d3b_2;
	public bool d4b_2;
	public bool d5b_2;
	public bool d6b_2;
	public bool d7b_2;
	public bool d8b_2;

	void Start () 
	{
		dialogueCtrl2 = this;
		speechRend2 = GetComponent<SpriteRenderer> ();
		speechRend2.sprite = invis2;
	}

	void Update ()
	{
		if (d1b_2 == true) {
			speechRend2.sprite = d1_2;
			d1b_2 = false;
		}
		if (d2b_2 == true) {
			speechRend2.sprite = d2_2;
			d2b_2 = false;
		}
		if (d3b_2 == true) {
			speechRend2.sprite = d3_2;
			d3b_2 = false;
		}
		if (d4b_2 == true) {
			speechRend2.sprite = d4_2;
			d4b_2 = false;
		}
		if (d5b_2 == true) {
			speechRend2.sprite = d5_2;
			d5b_2 = false;
		}
		if (d6b_2 == true) {
			speechRend2.sprite = d6_2;
			d6b_2 = false;
		}
		if (d7b_2 == true) {
			speechRend2.sprite = d7_2;
			d7b_2 = false;
		}
		if (d8b_2 == true) {
			speechRend2.sprite = d8_2;
			d8b_2 = false;
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogueController : MonoBehaviour {

	SpriteRenderer speechRend;
	public Sprite invis;
	public Sprite visible;

	void Start()
	{
		speechRend = GetComponent<SpriteRenderer> ();
		speechRend.sprite = invis;
	}

	void OnTriggerEnter2D(Collider2D speech)
	{
		speechRend.sprite = visible;
	}
}

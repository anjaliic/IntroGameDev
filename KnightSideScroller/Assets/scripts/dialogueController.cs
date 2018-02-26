using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogueController : MonoBehaviour {

	SpriteRenderer speechRend;
	public Sprite invis;
	public Sprite visible;
	public Sprite d2;
	public Sprite d3;

	BoxCollider2D d_collider;

	void Start()
	{
		speechRend = GetComponent<SpriteRenderer> ();
		speechRend.sprite = invis;
		d_collider = GetComponent<BoxCollider2D> ();
	}

	void Update()
	{
		if (speechRend.sprite == visible && Input.GetKeyDown(KeyCode.C) && this.gameObject.tag.Equals("convo"))
		{
				speechRend.sprite = d2;
		}
		if (speechRend.sprite == d2 && Input.GetKeyDown(KeyCode.C) && this.gameObject.tag.Equals("convo"))
		{
			speechRend.sprite = d3;
		}

		if (this.gameObject.name.Equals ("help1") && speechRend.sprite == d3)
		{
			areaController.areaCtrl.A1 = false;
		}
	}

	void OnTriggerEnter2D(Collider2D speech)
	{
		speechRend.sprite = visible;
		Destroy (d_collider);
	}
}

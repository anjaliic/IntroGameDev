using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class statController : MonoBehaviour {

	public static statController statCtrl;

	public Sprite statMax;
	public Sprite stat1;

	public SpriteRenderer statRend;
	public Transform statT;

	float statYpos;
	float statYscale;

	void Start()
	{
		statCtrl = this;
		statT = GetComponent<Transform> ();
		statRend = GetComponent<SpriteRenderer> ();
	}

	void Update()
	{
		StatIntro ();

		if (statManager.statMng.statReset == true) {
			statRend.sprite = stat1;
		}
}

	void StatIntro ()
	{
		if (this.gameObject.name.Equals ("speedBar") && statManager.statMng.speedBool == true) {
			statRend.sprite = statMax;
		}
		if (this.gameObject.name.Equals ("strengthBar") && statManager.statMng.strengthBool == true) {
			statRend.sprite = statMax;
		}
		if (this.gameObject.name.Equals ("skillBar") && statManager.statMng.skillBool == true) {
			statRend.sprite = statMax;
		}
		if (this.gameObject.name.Equals ("coinBar") && statManager.statMng.coinBool == true) {
			statRend.sprite = statMax;
		}
	}
}

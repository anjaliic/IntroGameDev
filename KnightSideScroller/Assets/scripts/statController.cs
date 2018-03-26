using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class statController : MonoBehaviour {

	public static statController statCtrl;

	public Sprite stat1;
	public Sprite stat2;
	public Sprite stat3;
	public Sprite stat4;
	public Sprite statMax;

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

		statStrength ();

		statCunning ();

		statWealth ();

		Reputation ();

		if (gameManager.gameMng.statReset == true) {
			gameManager.gameMng.strength = 1;
			gameManager.gameMng.cunning = 1;
			gameManager.gameMng.wealth = 1;
			gameManager.gameMng.rep = 1;
			gameManager.gameMng.statReset = false;
		}
}

	void StatIntro ()
	{
		if (this.gameObject.name.Equals ("strengthBar") && gameManager.gameMng.strengthBool == true) {
			statRend.sprite = statMax;
		}
		if (this.gameObject.name.Equals ("cunningBar") && gameManager.gameMng.cunningBool == true) {
			statRend.sprite = statMax;
		}
		if (this.gameObject.name.Equals ("wealthBar") && gameManager.gameMng.wealthBool == true) {
			statRend.sprite = statMax;
		}
		if (this.gameObject.name.Equals ("reputation") && gameManager.gameMng.repBool == true) {
			statRend.sprite = statMax;
		}
	}

	void statStrength ()
	{
		if (this.gameObject.name == ("strengthBar")) {
			if (gameManager.gameMng.strength == 1) {
				statRend.sprite = stat1;
			}
			if (gameManager.gameMng.strength == 2) {
				statRend.sprite = stat2;
			}
			if (gameManager.gameMng.strength == 3) {
				statRend.sprite = stat3;
			}
			if (gameManager.gameMng.strength == 4) {
				statRend.sprite = stat4;
			}
			if (gameManager.gameMng.strength == 5) {
				statRend.sprite = statMax;
			}
		}
	}

	void statCunning ()
	{
		if (this.gameObject.name == ("cunningBar")) {
			if (gameManager.gameMng.cunning == 1) {
				statRend.sprite = stat1;
			}
			if (gameManager.gameMng.cunning == 2) {
				statRend.sprite = stat2;
			}
			if (gameManager.gameMng.cunning == 3) {
				statRend.sprite = stat3;
			}
			if (gameManager.gameMng.cunning == 4) {
				statRend.sprite = stat4;
			}
			if (gameManager.gameMng.cunning == 5) {
				statRend.sprite = statMax;
			}
		}
	}

	void statWealth ()
	{
		if (this.gameObject.name == ("wealthBar")) {
			if (gameManager.gameMng.wealth == 1) {
				statRend.sprite = stat1;
			}
			if (gameManager.gameMng.wealth == 2) {
				statRend.sprite = stat2;
			}
			if (gameManager.gameMng.wealth == 3) {
				statRend.sprite = stat3;
			}
			if (gameManager.gameMng.wealth == 4) {
				statRend.sprite = stat4;
			}
			if (gameManager.gameMng.wealth == 5) {
				statRend.sprite = statMax;
			}
		}
	}

	void Reputation ()
	{
		if (this.gameObject.name == ("reputation")) {
			if (gameManager.gameMng.rep == 1) {
				statRend.sprite = stat1;
			}
			if (gameManager.gameMng.rep == 1) {
				statRend.sprite = stat1;
			}
			if (gameManager.gameMng.rep == 2) {
				statRend.sprite = stat2;
			}
			if (gameManager.gameMng.rep == 3) {
				statRend.sprite = stat3;
			}
			if (gameManager.gameMng.rep == 4) {
				statRend.sprite = stat4;
			}
		}
	}
}

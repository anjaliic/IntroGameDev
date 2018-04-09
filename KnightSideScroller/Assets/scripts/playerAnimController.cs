using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAnimController : MonoBehaviour {

	//stores animation stuffs/dont juice

	Animator anim;

	void Start ()
	{
		anim = GetComponent<Animator> ();
	}

	void Update ()
	{
		silverArmorAnimation ();
		rougeArmorAnimation ();
		keppelArmorAnimation ();
	}

	void silverArmorAnimation ()
	{
		if (gameManager.gameMng.choiceArmor == false)
		{
			if (playerController.playerCtrl.isWalking == true)
			{
				anim.SetBool ("s_idle", false);
				anim.SetBool ("s_walk", true);
			}
			else {
				anim.SetBool ("s_walk", false);
				anim.SetBool ("s_idle", true);
			}
		}
	}

	void rougeArmorAnimation ()
	{
		if (gameManager.gameMng.armor1 == true)
		{
			anim.SetBool ("silver", false);
			anim.SetBool ("rouge", true);
			anim.SetBool ("s_idle", false);
			anim.SetBool ("s_walk", false);

			if (playerController.playerCtrl.isWalking == true) 
			{
				anim.SetBool ("r_idle", false);
				anim.SetBool ("r_walk", true);
			}
			else {
				anim.SetBool ("r_walk", false);
				anim.SetBool ("r_idle", true);
			}
		}
	}

	void keppelArmorAnimation ()
	{
		if (gameManager.gameMng.armor2 == true)
		{
			anim.SetBool ("silver", false);
			anim.SetBool ("keppel", true);
			anim.SetBool ("s_idle", false);
			anim.SetBool ("s_walk", false);
			if (playerController.playerCtrl.isWalking == true)
			{
				anim.SetBool ("k_idle", false);
				anim.SetBool ("k_walk", true);
			}
			else {
				anim.SetBool ("k_walk", false);
				anim.SetBool ("k_idle", true);
			}
		}
	}
}

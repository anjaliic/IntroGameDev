﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class areaController : MonoBehaviour {

	public static areaController areaCtrl;

	public bool A1 = true;

	BoxCollider2D areaCollider;

	void Start () 
	{
		areaCtrl = this;
		areaCollider = GetComponent<BoxCollider2D> ();
	}

	void Update () 
	{
//		if(){
//		if(this.gameObject.name.Equals("A_1") && A1 == false)
//		{
//			Destroy (this.areaCollider);
//			A1 = true;
//		}
//		}
	}
}

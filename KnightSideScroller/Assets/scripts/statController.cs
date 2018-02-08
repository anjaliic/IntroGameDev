using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class statController : MonoBehaviour {

	public static statController statCtrl;

	//player stats
	public float speedStat = 1f; 
	public float strengthStat;
	public float skillStat;
	public float coinStat;

	// Use this for initialization
	void Start ()
	{
		statCtrl = this;
		GetComponentInChildren<Transform> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		foreach (Transform child in transform) 
		{

		}
	}
}

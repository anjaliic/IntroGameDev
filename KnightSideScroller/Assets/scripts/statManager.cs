using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class statManager : MonoBehaviour {

	public static statManager statMng;

	//player stats
	public float speedStat; 
	public float strengthStat;
	public float skillStat;
	public float coinStat;

	public bool statReset = false;

	public bool speedBool = false; 
	public bool strengthBool = false;
	public bool skillBool = false;
	public bool coinBool = false;

	// Use this for initialization
	void Start ()
	{
		statMng = this;
		GetComponentInChildren<Transform> ();
	}
		
}

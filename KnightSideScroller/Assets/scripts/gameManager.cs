using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour {

	public static gameManager gameMng;

	//armor choice
	public bool choiceArmor;

	//	public int armor;
	public bool armor1;
	public bool armor2;

	public bool statReset;

	//stat stuff
	public bool strengthBool;
	public bool cunningBool;
	public bool wealthBool;
	public bool repBool;

	public int strength;
	public int cunning;
	public int wealth;
	public int rep;

	//item choice
	public bool choiceItem;

	public bool item1;
	public bool item2;
	public bool item3;

	//search location choice
	public bool choiceSearch;

	public bool search1;
	public bool search2;

	void Start()
	{
		gameMng = this;
	}

	void Awake()
	{
		DontDestroyOnLoad (this);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour {

	public static gameManager gameMng;

	public Font narrateFont;

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

	//search location choice
	public bool choiceSearch;

	public bool search1;
	public bool search2;

	public bool starterGold;

	public bool choiceQ1;
	public bool q1_1;
	public bool q1_2;

	public bool choiceGift;

	public bool gift1;
	public bool gift2;
	public bool gift3;

	void Start()
	{
		gameMng = this;
	}

	void Awake()
	{
		DontDestroyOnLoad (this);
	}
}

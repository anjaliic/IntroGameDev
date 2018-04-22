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

	public bool starterGold;

	public bool choiceQ1;
	public bool q1_1;
	public bool q1_2;

	public bool choiceGift;

	public bool gift1;
	public bool gift2;
	public bool gift3;

	//SCENE: RIVER
	public bool showQ2; //whether or not to show the Question in the "river" scene

	public bool choiceQ2;
	public bool q2_1;
	public bool q2_2;

	public bool showQ3;

	public bool choiceQ3;
	public bool q3_1;
	public bool q3_2;

	public bool showQ4_1;
	public bool showQ4_2;

	public bool choiceQ4;
	public bool q4_1_1;
	public bool q4_1_2;
	public bool q4_2;

	public bool nice; // if you are nice to the kid 
	public bool askDog; //if you find out about the dog 

	public bool choiceSearch;
	public bool search1;
	public bool search2;


	public bool showTroll;

	public bool choiceTroll;
	public bool troll1;
	public bool troll2;

	public bool showTroll2;

	public bool choiceTroll2;
	public bool troll1_2;
	public bool troll2_2;



	void Start()
	{
		gameMng = this;
	}

	void Awake()
	{
		DontDestroyOnLoad (this);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textManager : MonoBehaviour {

	public static textManager textMng;

	public bool introN1 = true;
	public bool introN2 = true;
	public bool introN3 = true;
	public bool introN4 = true;

	public bool armorN1 = true;
	public bool armorN2 = true;
	public bool armorN3 = true;

	public bool statN1 = true;
	public bool statN2 = true;
	public bool statN3 = true;
	public bool statN4 = true;
	public bool statN5 = true;
	public bool statN6 = true;


	void Start()
	{
		textMng = this;
	}
}

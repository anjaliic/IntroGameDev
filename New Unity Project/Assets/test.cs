using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text;

public class test : MonoBehaviour {

	private static string TestFunction(string stringInput)
	{


		if (string.IsNullOrEmpty(stringInput)) return string.Empty;
		var stringBuilder = new StringBuilder(stringInput);

		var count = 0;


		while (count < stringBuilder.Length / 2)
		{
			var temp = stringBuilder[count];
			stringBuilder[count] = stringBuilder[stringBuilder.Length - count - 1];
			stringBuilder[stringBuilder.Length - count - 1] = temp;
			++count;
		}

		return stringBuilder.ToString();

	}





	void Start ()
	{
		Debug.Log (TestFunction ("What does this do?"));
	}
}

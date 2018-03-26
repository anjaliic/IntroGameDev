using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCalc : MonoBehaviour {

	Camera cam;
	Color appliedColor;

	public Color inputColor1;
	public Color inputColor2;

	private void Start()
	{
		cam = GetComponent<Camera> ();
	}

	private void Update()
	{
		cam.backgroundColor = appliedColor;
	}

	private void _ColorCalc(Color c1, Color c2)
	{
		appliedColor = c1 * c2;
	}
}

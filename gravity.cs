using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravity : MonoBehaviour {
	private bool enter = false;




	void Start ()
	{

	}

	void OnTriggerEnter2D(Collider2D other) {
		enter = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (enter == true) 
		{
			
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectable : MonoBehaviour {
	public GameManager gm;
	public int value;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D c){
		if(c.gameObject.CompareTag("light")){
			gm.addscore(value);
			Destroy (gameObject);
		}
	}
}

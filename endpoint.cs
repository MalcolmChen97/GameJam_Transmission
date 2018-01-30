using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endpoint : MonoBehaviour {
	public GameManager gm;
	public int value;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (0, 0, 45) * Time.deltaTime);
	}


	void OnTriggerEnter2D(Collider2D c){
		if(c.gameObject.CompareTag("light")){
			gm.addscore(value);
			gm.nextLevel ();
		}
	}
}

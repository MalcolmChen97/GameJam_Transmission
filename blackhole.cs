using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blackhole : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay2D(Collider2D col){
		if (col.gameObject.CompareTag ("light")) {
			Debug.Log ("in hole");
			col.gameObject.GetComponent<Rigidbody2D> ().AddForce (transform.position * 20);
		}
	}
}

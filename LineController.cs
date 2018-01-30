using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineController : MonoBehaviour {
	Rigidbody2D lightball;
	// Use this for initialization
	void Awake () {
		lightball = GetComponent<Rigidbody2D> ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void shoot(Vector2 direction){
		lightball.AddForce ( direction * 100, ForceMode2D.Force);
	}

	void OnBecameInvisible() {
		Destroy(gameObject,2f);
	}


}

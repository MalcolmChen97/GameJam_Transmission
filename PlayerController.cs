using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float speed = 5;
	private Rigidbody2D rb2d;
	private bool Infield = false;

	void Start ()
	{
		rb2d = GetComponent<Rigidbody2D> ();
	}


	void OnTriggerEnter2D(Collider2D other) {

		if (other.gameObject.name == "blackhole")
		{ // if the hit object's name is Wall...
			Infield = true;
		}	
		if (other.gameObject.name == "Refract") {
			Vector2 force = new Vector2 (500, 500);
			rb2d.AddForce (force);
		}

	}
	void FixedUpdate() 
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
		rb2d.AddForce (movement * speed);

		if (Infield == true) 
		{
			rb2d.transform.Translate (new Vector2(-11,4) * 0.3f);
			Infield = false;
		}

	}
}


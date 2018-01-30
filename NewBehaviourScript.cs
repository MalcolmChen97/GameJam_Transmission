using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
	public float speed = 5;
	private Rigidbody2D rb2d;
	private bool Infield = false;

	void Start ()
	{
		Debug.Log("1");
		rb2d = GetComponent<Rigidbody2D> ();
	}


	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log("2");

		if (other.gameObject.name == "blackhole")
		{ // if the hit object's name is Wall...
			Infield = true;
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

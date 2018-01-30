using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycasting : MonoBehaviour {
	public GameObject light_prefab;
	public LayerMask notToHit;
	public GameObject ufo;
	Vector2 mousepos;
	public GameManager gm;
	// Use this for initialization
	void Awake () {

	}
	
	// Update is called once per frame
	void Update () {

		faceMouse ();


		if (Input.GetMouseButtonDown (0)&&gm.transmissions>0) {
			shoot ();
			gm.usetransmission ();
		}
			
	}

	void faceMouse(){
		Vector3 mousePosition = Input.mousePosition;

		mousePosition = Camera.main.ScreenToWorldPoint (mousePosition);

		Vector2 direction = new Vector2 (
			                    mousePosition.x - transform.position.x,
			                    mousePosition.y - transform.position.y);

		transform.up = direction;
		mousepos = direction;
	}

	void shoot(){

		GameObject light = Instantiate (light_prefab, transform.position+transform.up, Quaternion.identity) as GameObject;
		light.GetComponent<LineController>().shoot (mousepos);

	}
}

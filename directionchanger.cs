using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class directionchanger : MonoBehaviour {
	public GameObject light_prefab;
	public Transform start;
	public Transform end;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.CompareTag ("light")) {
			Vector2 target = new Vector2 (
				end.position.x - start.position.x,
				end.position.y - start.position.y);
			Rigidbody2D haha = col.gameObject.GetComponent<Rigidbody2D> ();
			haha.velocity = new Vector2(0,0);
			Destroy (col.gameObject, 1f);
			GameObject light = Instantiate (light_prefab, end.position, Quaternion.identity) as GameObject;
			light.GetComponent<LineController>().shoot (target * 20);

		}
	}

}

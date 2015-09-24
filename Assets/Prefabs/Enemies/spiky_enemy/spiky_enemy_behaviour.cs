using UnityEngine;
using System.Collections;

public class spiky_enemy_behaviour : MonoBehaviour {

	float forcePower = 2500;
	bool triggered = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D (Collision2D col) {
		if (col.gameObject.tag == "Player") {
			if(!triggered){
				triggered = true;
				col.rigidbody.velocity = new Vector2(0,	0);
				Vector2 forceVector = new Vector2(0, forcePower);
				col.rigidbody.AddForce(forceVector);
			}
		}
	}

	void OnCollisionExit2D(Collision2D col){
		if (col.gameObject.tag == "Player") {
			triggered = false;
		}
	}
}

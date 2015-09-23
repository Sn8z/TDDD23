using UnityEngine;
using System.Collections;

public class spiky_enemy_behaviour : MonoBehaviour {

	public float forcePower = 1000;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D (Collision2D col) {
		if (col.gameObject.tag == "Player") {
			//target = col.gameObject.GetComponent<Rigidbody2D>();
			//col.rigidbody.AddForce(new Vector2(0, 1000));
			//Vector2 forceVector = col.rigidbody.velocity.normalized * forcePower;
			col.rigidbody.velocity = new Vector2(0,	0);
			col.rigidbody.AddForce(col.transform.right*forcePower);

			//var forceVec : Vector3 = -target_.rigidbody.velocity.normalized * explosionStrength;
			//target_.rigidbody.AddForce(forceVec,ForceMode.Acceleration);
		}
	}
}

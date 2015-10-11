using UnityEngine;
using System.Collections;

public class fall_death_script : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Player") {
			if (col.gameObject.GetComponent<PlayerControllerScriptShooting> () != null) {
				col.gameObject.GetComponent<PlayerControllerScriptShooting> ().killPlayer ();
			} else {
				col.gameObject.GetComponent<PlayerControllerScript> ().killPlayer ();
			}
		}
	}
}

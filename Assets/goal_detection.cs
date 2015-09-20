using UnityEngine;
using System.Collections;

public class goal_detection : MonoBehaviour {
	public int levelToLoad = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D (Collision2D col) {
		if (col.gameObject.tag == "Player") {
			Application.LoadLevel(levelToLoad);
		}
	}
}

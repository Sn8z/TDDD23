using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class goal_detection : MonoBehaviour {
	public int levelToLoad = 0;
	public Canvas endScreen;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D (Collision2D col) {
		if (col.gameObject.tag == "Player") {
			Time.timeScale = 0f;
			endScreen.enabled = true;
		}
	}
}

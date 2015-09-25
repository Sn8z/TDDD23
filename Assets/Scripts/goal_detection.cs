using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class goal_detection : MonoBehaviour {
	public Canvas endScreen;
	public EventSystem es;
	public GameObject continueBtn;
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
			es.SetSelectedGameObject(continueBtn);
		}
	}
}

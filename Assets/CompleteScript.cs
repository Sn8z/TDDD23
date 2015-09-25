using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

public class CompleteScript : MonoBehaviour {
	
	public Canvas cv;
	public EventSystem es;
	public Button continueBtn;
	public Button menuBtn;
	//public int levelToLoad = 0;

	
	// Use this for initialization
	void Start () {
		cv.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (cv.enabled) {
			es.SetSelectedGameObject(continueBtn, null);
		}

	}

	public void nextLevel(int levelToLoad){
		Application.LoadLevel (levelToLoad);
		Time.timeScale = 1f;
	}

	public void mainMenu(){
		Application.LoadLevel (0);
		Time.timeScale = 1f;
	}
}

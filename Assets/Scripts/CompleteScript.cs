using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CompleteScript : MonoBehaviour {
	
	public Canvas cv;
	public Button continueBtn;
	public Button menuBtn;
	public bool isActive = false;
	//public int levelToLoad = 0;

	
	// Use this for initialization
	void Start () {
		cv.enabled = false;
		continueBtn.interactable = false;
		menuBtn.interactable = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (!isActive && cv.enabled) {
			continueBtn.interactable = true;
			menuBtn.interactable = true;
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

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CompleteScript : MonoBehaviour {
	
	public Canvas cv;
	public Button continueBtn;
	public Button menuBtn;
	public bool isActive = false;

	
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

	public void nextLevel(string levelToLoad){
		Application.LoadLevel (levelToLoad);
		Time.timeScale = 1f;
	}

	public void mainMenu(){
		Application.LoadLevel ("mainmenu");
		Time.timeScale = 1f;
	}
}

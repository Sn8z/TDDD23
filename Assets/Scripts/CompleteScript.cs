using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CompleteScript : MonoBehaviour {
	
	public Canvas cv;
	public Button continueBtn;
	public bool active = false;
	//public int levelToLoad = 0;

	
	// Use this for initialization
	void Start () {
		cv.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {


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

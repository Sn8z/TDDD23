using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PauseScript : MonoBehaviour {

	public Canvas cv;
	public Button resumeTxt;
	public Button restartTxt;
	public Button exitTxt;

	// Use this for initialization
	void Start () {
		cv.enabled = false;
		resumeTxt.interactable = false;
		restartTxt.interactable = false;
		exitTxt.interactable = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Pause")) {
			toggle_pause();
		}
	}

	public void toggle_pause(){
		if (cv.enabled)
		{
			cv.enabled = false;
			resumeTxt.interactable = false;
			restartTxt.interactable = false;
			exitTxt.interactable = false;
			Input.ResetInputAxes();
			Time.timeScale = 1.0f;
		}
		else
		{
			cv.enabled = true;
			resumeTxt.interactable = true;
			restartTxt.interactable = true;
			exitTxt.interactable = true;
			Time.timeScale = 0f;
		}
	}
	public void mainMenu(){
		Application.LoadLevel ("mainmenu");
		Time.timeScale = 1.0f;
	}
	public void resetLevel(){
		Application.LoadLevel (Application.loadedLevel);
		Time.timeScale = 1.0f;
	}
}

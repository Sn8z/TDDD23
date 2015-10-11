using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimerScript : MonoBehaviour {
	float timer = 0f;
	public GameObject timerText;
	public GameObject hsText;
	Text displayTimeText;
	Text highscoreText;
	float highscore;

	// Use this for initialization
	void Start () {
		displayTimeText = timerText.GetComponent<Text> ();
		highscoreText = hsText.GetComponent<Text>();
		highscore = PlayerPrefs.GetFloat (Application.loadedLevelName);
		if (highscore == 0) {
			highscore = 9999999999;
		} else {
			highscoreText.text = "Highscore: " + highscore.ToString("0.00") + " s";
		}
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		displayTimeText.text = timer.ToString("0.00") + " s";
	}

	public void updateHighscore(){
		if (timer < highscore) {
			highscoreText.text = "Highscore: " + timer.ToString("0.00") + " s";
			displayTimeText.text = timer.ToString("0.00") + " s";
			PlayerPrefs.SetFloat(Application.loadedLevelName, timer);
		}
	}
}

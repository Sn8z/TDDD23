using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimerScript : MonoBehaviour {
	float timer = 0f;
	Text displayText;
	// Use this for initialization
	void Start () {
		displayText = this.gameObject.GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;

		displayText.text = timer.ToString("0.00") + " s";
	}
}

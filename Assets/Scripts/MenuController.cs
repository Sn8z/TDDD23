using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuController : MonoBehaviour {
	public void exitGame(){
		Debug.LogError ("Quit Application");
		Application.Quit ();
	}
}

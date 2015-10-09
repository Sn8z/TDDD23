using UnityEngine;
using System.Collections;

public class MenuFunctions : MonoBehaviour {

	public void loadLevel(string level){
		Application.LoadLevel (level);
	}

	public void exitGame(){
		Debug.LogError ("Quit Application");
		Application.Quit ();
	}
}

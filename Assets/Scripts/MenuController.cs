using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuController : MonoBehaviour {
	public void loadLevel(int level){
		Application.LoadLevel (level);
	}

	public void exitGame(){
		Debug.LogError ("Quit Application");
		Application.Quit ();
	}
}

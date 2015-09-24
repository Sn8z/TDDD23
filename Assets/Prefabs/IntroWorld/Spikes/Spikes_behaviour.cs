using UnityEngine;
using System.Collections;

public class Spikes_behaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.tag == "Player"){
			//yield return new WaitForSeconds(3);
			Application.LoadLevel(Application.loadedLevelName);
		}
	}
}

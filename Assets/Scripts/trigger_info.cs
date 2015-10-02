using UnityEngine;
using System.Collections;

public class trigger_info : MonoBehaviour {

	public int infoNr;

	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.tag == "tutorial_guy"){
			col.gameObject.GetComponent<tutorial_follower>().showBubble(infoNr);
		}
	}

	void OnTriggerExit2D(Collider2D col){
		if(col.gameObject.tag == "tutorial_guy"){
			col.gameObject.GetComponent<tutorial_follower>().hideBubble(infoNr);
		}
	}
}

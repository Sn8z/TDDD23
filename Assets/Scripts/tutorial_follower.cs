using UnityEngine;
using System.Collections;

public class tutorial_follower : MonoBehaviour {

	public Transform player;
	float offsetX = -1.5f;
	float offsetY = 1.5f;
	float smoothTime = 2f;
	bool facingRight = true;
	Transform thisTransform;

	//Thought bubbles
	public GameObject tBubble1;
	public GameObject tBubble2;
	public GameObject tBubble3;

	// Use this for initialization
	void Start () {
		thisTransform = transform;
		tBubble1.SetActive(false);
		tBubble2.SetActive(false);
		tBubble3.SetActive(false);
	}

	void FixedUpdate (){
		Vector2 temp = thisTransform.position;
		temp.x = Mathf.Lerp( thisTransform.position.x, player.position.x + offsetX, Time.deltaTime * smoothTime);
		temp.y = Mathf.Lerp( thisTransform.position.y, player.position.y + offsetY, Time.deltaTime * smoothTime);

		if (thisTransform.position.x < temp.x && !facingRight)
			Flip ();
		else if (thisTransform.position.x > temp.x && facingRight)
			Flip ();

		thisTransform.position = temp;
	}

	void Flip() {
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}

	public void showBubble(int number){
		switch (number)
		{
		case 1:
			tBubble1.SetActive(true);
			break;
		case 2:
			tBubble2.SetActive(true);
			break;
		case 3:
			tBubble3.SetActive(true);
			break;
		default:
			break;
		}
	}

	public void hideBubble(int number){
		switch (number)
		{
		case 1:
			tBubble1.SetActive(false);
			break;
		case 2:
			tBubble2.SetActive(false);
			break;
		case 3:
			tBubble3.SetActive(false);
			break;
		default:
			break;
		}
	}
}

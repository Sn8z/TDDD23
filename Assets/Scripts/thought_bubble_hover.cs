using UnityEngine;
using System.Collections;

public class thought_bubble_hover : MonoBehaviour {
	
	public Transform target;
	float offsetX = 2f;
	float offsetY = 1.5f;
	float smoothTime = 10f;
	Transform thisTransform;

	// Use this for initialization
	void Start () {
		thisTransform = transform;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector2 temp = thisTransform.position;
		temp.x = Mathf.Lerp( thisTransform.position.x, target.position.x + offsetX, Time.deltaTime * smoothTime);
		temp.y = Mathf.Lerp( thisTransform.position.y, target.position.y + offsetY, Time.deltaTime * smoothTime);
		thisTransform.position = temp;
	}
}

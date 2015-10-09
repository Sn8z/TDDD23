using UnityEngine;
using System.Collections;

public class invert_object_gravity : MonoBehaviour {

    Rigidbody2D rb2d;
    bool isInverted = false;

	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.tag == "gravity_invert" && !isInverted){
            StartCoroutine(Invert());
        }
    }

    IEnumerator Invert()
    {
        isInverted = true;
        float gravityTemp = rb2d.gravityScale;
        rb2d.gravityScale = rb2d.gravityScale * -1;
        yield return new WaitForSeconds(4);
        rb2d.gravityScale = gravityTemp;
        isInverted = false;
    }
}

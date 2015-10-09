using UnityEngine;
using System.Collections;

public class freeze_object : MonoBehaviour {

    Rigidbody2D rb2d;
    bool isFrozen = false;

	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.tag == "snowball" && !isFrozen){
            StartCoroutine(Freeze());
        }
    }

    IEnumerator Freeze()
    {
        isFrozen = true;
        Vector2 velTemp = rb2d.velocity;
        rb2d.velocity = Vector2.zero;
        RigidbodyConstraints2D constraintsTemp = rb2d.constraints;
        rb2d.constraints = RigidbodyConstraints2D.FreezeAll;
        yield return new WaitForSeconds(4);
        rb2d.constraints = constraintsTemp;
        rb2d.velocity = velTemp;
        isFrozen = false;
    }
}

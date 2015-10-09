using UnityEngine;
using System.Collections;

public class snowball_behaviour : MonoBehaviour {
    void OnCollisionEnter2D(Collision2D col) {
        Destroy(gameObject);
    }
}

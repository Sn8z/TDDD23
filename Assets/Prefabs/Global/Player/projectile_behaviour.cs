using UnityEngine;
using System.Collections;

public class projectile_behaviour : MonoBehaviour {
    void OnCollisionEnter2D(Collision2D col) {
        //Maybe create an "explosion" animation
        Destroy(gameObject);
    }
}

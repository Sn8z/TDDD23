﻿using UnityEngine;
using System.Collections;

public class MusicScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (this);
	
		if (FindObjectsOfType (GetType ()).Length > 1) {
			Destroy(gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

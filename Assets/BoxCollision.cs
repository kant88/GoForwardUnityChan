﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D (Collision2D other) {
		if (other.gameObject.tag == "UnityChan" || other.gameObject.tag == "Cube" || other.gameObject.tag == "Ground") {
			GetComponent<AudioSource> ().Play ();
		}
	}
}

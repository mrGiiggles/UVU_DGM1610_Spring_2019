﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakable : MonoBehaviour {


	public int health;
	public Sprite[] sprites;

	// private void Awake() {
	// 	GetComponent<SpriteRenderer>().sprite = sprites[health];

	// }

	private void OnCollisionEnter2D(Collision2D col) {
		health--;
		GetComponent<SpriteRenderer>().sprite = sprites[health];
		
		//destroy game object when health is zero.

		if (health <= 0) {
			Destroy(gameObject);
		}
	}

}
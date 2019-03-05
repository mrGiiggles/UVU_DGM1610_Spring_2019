﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	//player movement variables
	public float moveSpeed;
	public float jumpHeight;

	//player grounded variables
	private bool grounded;
	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;


	// Use this for initialization
	void Start () {
		// default to true on grounded
		
	}

	void FixedUpdate(){
		grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
	}

	//this and && that
	//this or || that
	// !Not
	
	// Update is called once per frame
	void Update () {
		//moves player left & right
		if(Input.GetKey(KeyCode.D)){
			GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
		}

		else if(Input.GetKey(KeyCode.A)){
			GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
		}
			
			//Makes player jump
		if(Input.GetKeyDown(KeyCode.W) && grounded){
			Jump();
		}


	}

	void Jump() {
		GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
	}
}

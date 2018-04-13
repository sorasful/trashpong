using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaccoonPlayer1 : MonoBehaviour {

	public float raccoonSpeed = 2f;
	public float raccoonLimitYScreen = 2.20f;
	private Rigidbody2D raccoonPaddle;

	// Use this for initialization
	void Start () {
		raccoonPaddle = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		var vel = raccoonPaddle.velocity;
		if (Input.GetKey (KeyCode.Q)) {
			vel.y = raccoonSpeed;
		} else if (Input.GetKey (KeyCode.W)) {
			vel.y = -raccoonSpeed;
		} else if (!Input.anyKey) {
			vel.y = 0;
		}
		raccoonPaddle.velocity = vel;


        // Empêcher le raccoonPaddle de sortir du screen 
		var pos = transform.position;
		if (pos.y > raccoonLimitYScreen) {
			pos.y = raccoonLimitYScreen;
		}

        if (pos.y < -raccoonLimitYScreen) {
			pos.y = -raccoonLimitYScreen;
		}

        transform.position = pos;
	}
}

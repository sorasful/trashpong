using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour {

	private Rigidbody2D raccoonRigidBody;
	private Vector2 raccoonVelocity;

	void raccoonBallStart() {
		float rand = Random.Range (0, 2);
        // pour ne pas commencer toujours du même côté
		if (rand < 1) {
			raccoonRigidBody.AddForce (new Vector2(10, -15));
		} else {
			raccoonRigidBody.AddForce (new Vector2 (-10, 15));
		}
	}

	// Use this for initialization
	void Start () {
		raccoonRigidBody = GetComponent<Rigidbody2D> ();
		Invoke ("raccoonBallStart", 2);  // mettre un délai avant le start
	}

	

	void OnCollisionEnter2D(Collision2D collision) {  // Plus simple que d'utiliser les coordonnées X et Y.
		if (collision.collider.CompareTag ("Player")) {
			raccoonVelocity.x = raccoonRigidBody.velocity.x;
			raccoonVelocity.y = (raccoonRigidBody.velocity.y / 1.8f) + (collision.collider.attachedRigidbody.velocity.y / 2.9f); 
			raccoonRigidBody.velocity = raccoonVelocity;
		}
	}

}

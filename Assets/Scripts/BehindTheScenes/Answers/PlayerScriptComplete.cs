using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScriptComplete : MonoBehaviour {

	public Rigidbody2D rigidbody_;
	public PlayerBottomCollider groundCollider;

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space) && groundCollider.isGrounded) {
			jump ();
		}

	}

	public void jump() {
		rigidbody_.AddForce (new Vector2 (0f, 100f));
		groundCollider.isGrounded = false;
	}
}

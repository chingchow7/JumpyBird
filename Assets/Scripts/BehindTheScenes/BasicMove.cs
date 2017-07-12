using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMove : MonoBehaviour {

	public float speed = -5f;

	private Rigidbody2D rigidbody_;

	// Use this for initialization
	void Start () {
		rigidbody_ = this.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody_.velocity = new Vector2 (speed, 0);
	}
}

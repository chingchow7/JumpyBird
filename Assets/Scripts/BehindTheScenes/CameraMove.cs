using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

	public PlayerLib playerLib_;

	private GameManager gameManager_;

	// Use this for initialization
	void Start () {
		gameManager_ = GameObject.Find ("GameManager").GetComponent<GameManager> ();
	}

	// Update is called once per frame
	void Update () {
		if (gameManager_.gameStarted) {
			this.gameObject.transform.Translate (Vector3.right * Time.deltaTime*playerLib_.playerspeed);
		}
	}
}

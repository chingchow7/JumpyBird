using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLib : MonoBehaviour {

	public float playerspeed = 5f;

	private GameManager gameManager_;
	private ScoreManager scoreManager_;

	// Use this for initialization
	void Start () {
		gameManager_ = GameObject.Find ("GameManager").GetComponent<GameManager> ();
		scoreManager_ = GameObject.Find ("GameManager").GetComponent<ScoreManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (gameManager_.gameStarted) {
			this.gameObject.transform.Translate (Vector3.right * Time.deltaTime * playerspeed);
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "ScoreCollider") {
			scoreManager_.score++;
			other.gameObject.SetActive (false);
		}

		if (other.gameObject.tag == "KillCollider") {
			gameManager_.playerDead = true;
		}
	}
}

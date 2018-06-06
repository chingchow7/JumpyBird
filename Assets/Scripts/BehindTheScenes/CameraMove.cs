using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

	public PlayerScript playerScript_;

	private GameManager gameManager_;

	// Use this for initialization
	void Start () {
        playerScript_ = GameObject.Find("Player").GetComponent<PlayerScript>();
		gameManager_ = GameObject.Find ("GameManager").GetComponent<GameManager> ();
	}

	// Update is called once per frame
	void Update () {
		if (gameManager_.gameStarted && !gameManager_.playerDead) {
			this.gameObject.transform.Translate (Vector3.right * Time.deltaTime* playerScript_.playerspeed);
		}
	}
}

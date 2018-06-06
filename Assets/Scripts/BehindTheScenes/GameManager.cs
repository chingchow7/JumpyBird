using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public bool gameStarted = false;
	public bool playerDead = false;

	private PlayerScript playerScript_;
	private GUIManager guiManager_;
	private ScoreManager scoreManager_;

	// Use this for initialization
	void Start () {
		playerScript_ = GameObject.Find ("Player").GetComponent<PlayerScript> ();
		guiManager_ = this.GetComponent<GUIManager> ();
		scoreManager_ = this.GetComponent<ScoreManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		if ((Input.GetKeyDown (KeyCode.Return)||Input.GetKeyDown(KeyCode.KeypadEnter)) && !gameStarted) {
			gameStarted = true;
		}

		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit ();
		}
	}
}

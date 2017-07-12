using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public bool gameStarted = false;
	public bool playerDead = false;

	private PlayerLib playerLib_;
	private GUIManager guiManager_;
	private ScoreManager scoreManager_;

	// Use this for initialization
	void Start () {
		playerLib_ = GameObject.Find ("Player").GetComponent<PlayerLib> ();
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

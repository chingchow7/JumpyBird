using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GUIManager : MonoBehaviour {

	private GameObject SpaceToStartText;
	private GameObject highScoreText;
	private Text scoreText;
	private Text HSText;
	private GameObject RetryButton;
	private ScoreManager scoreManager_;
	private GameManager gameManager_;
	private int highScore;

	// Use this for initialization
	void Start () {
		gameManager_ = this.GetComponent<GameManager> ();
		SpaceToStartText = GameObject.Find ("SpaceToStartText");
		highScoreText = GameObject.Find ("HighScoreText");
		HSText = highScoreText.GetComponent<Text> ();
		scoreText = GameObject.Find ("scoreText").GetComponent<Text> ();
		scoreManager_ = this.GetComponent<ScoreManager> ();
		RetryButton = GameObject.Find ("RetryButton");

		RetryButton.SetActive (false);
		HSText.text = "High Score: " + scoreManager_.getHighScore ();
	}
	
	// Update is called once per frame
	void Update () {
		if (gameManager_.gameStarted) {
			SpaceToStartText.SetActive (false);
			highScoreText.SetActive (false);
		} else {
			SpaceToStartText.SetActive (true);
			highScoreText.SetActive (true);
		}

		if (gameManager_.gameStarted) {
			// Update the score text
			scoreText.text = "Score: " + scoreManager_.score;
		}

		// PLAYER DIED. END THE GAME
		if (gameManager_.playerDead) {
			RetryButton.SetActive (true);
			highScoreText.SetActive (true);
			highScore = scoreManager_.getHighScore ();

			if (scoreManager_.score > highScore) {
				scoreManager_.SetHighScore (scoreManager_.score);
			}

			HSText.text = "High Score: " + scoreManager_.getHighScore ();
		}
	}

	public void RetryButtonFunc () {
		Debug.Log ("starting game!");
		Application.LoadLevel("Game");
	}
}

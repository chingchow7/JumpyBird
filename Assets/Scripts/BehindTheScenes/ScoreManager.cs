using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

	public int score = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public bool SetHighScore (int score) {
		string key = "highscore";
		bool newHigh = false;

		if (PlayerPrefs.HasKey(key)) {
			if ( PlayerPrefs.GetInt(key) < score) {
				newHigh = true;
				PlayerPrefs.SetInt(key, score);
			}
		} else {
			PlayerPrefs.SetInt(key,score);
			newHigh = true;
		}
		return newHigh;
	}

	public int getHighScore() {
		string key = "highscore";

		return PlayerPrefs.GetInt(key);
	}

	public void clearHighScore() {
		string key = "highscore";

		PlayerPrefs.SetInt(key,0);
	}
}

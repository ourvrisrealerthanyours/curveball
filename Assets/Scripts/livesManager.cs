using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class livesManager : MonoBehaviour {

	public int enemyLivesPerLevel = 1;

	public int playerLives = 3;
	public int level = 1;
	public Text scoreDisplay;
	public TextMesh levelDisplay;
	public GameObject ball;

	private ballManager bm;
	private int enemyLives;
	// Use this for initialization
	void Start () {
		
		bm = ball.GetComponent<ballManager> ();
		UpdateScoreDisplay ();
		levelDisplay.text = "";
		enemyLives = enemyLivesPerLevel;
	}

	public void wallHit (string side) {
		// pause
		bm.pause ();

		if (side == "Enemy") {
			decreaseEnemyLife ();
		} else {
			decreasePlayerLife ();
		}

		UpdateScoreDisplay ();
		// resume
	}

	void UpdateScoreDisplay () {
		scoreDisplay.text = "Player Lives: " + playerLives.ToString () + " Enemy Lives: " + enemyLives.ToString ();
	}

	public void decreasePlayerLife () {
		playerLives--;
		if (playerLives == 0) {
			playerDies ();
		} else {
			nextPoint ();
		}
	}

	public void decreaseEnemyLife () {
		enemyLives--;
		if (enemyLives == 0) {
			enemyDies ();
		} else {
			nextPoint ();
		}
	}

	public void playerDies() {
		enemyLives = 3;
		playerLives = 3;
	}

	public void enemyDies() {
		StartCoroutine(StartNewLevel());
	}

	private void nextPoint() {
		bm.reset ();
		bm.spank ();
	}


	IEnumerator StartNewLevel () {
		// Display level
		// setTimeout
		// fade out
		level++;
		enemyLives = enemyLivesPerLevel;
		levelDisplay.text = "Level " + level.ToString ();
		yield return new WaitForSeconds (3);
		levelDisplay.text = "";
		nextPoint ();
	}
}

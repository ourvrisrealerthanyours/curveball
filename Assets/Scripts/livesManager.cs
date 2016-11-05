using UnityEngine;
using System.Collections;

public class livesManager : MonoBehaviour {

	public int enemyLives = 3;
	public int playerLives = 3;
	public int level = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void decrementLives (string side) {
		if (side == "Enemy") {
			decreaseEnemyLife ();
		} else {
			decreasePlayerLife ();
		}
	}

	public void decreasePlayerLife () {
		Debug.Log ("Player lost life");
		playerLives--;	
		if (playerLives == 0) {
			Debug.Log("you dead, huh");
			enemyLives = 3;
			playerLives = 3;
		}
	}

	public void decreaseEnemyLife () {
		Debug.Log ("Enemy lost life");
		enemyLives--;
		if (enemyLives == 0) {
			Debug.Log("he dead, doe");
			enemyLives = 3;
			level++;
		}
	}
}

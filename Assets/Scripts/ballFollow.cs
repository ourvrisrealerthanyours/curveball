using UnityEngine;
using System.Collections;

public class ballFollow : MonoBehaviour {

	public GameObject ballToFollow;
	public float speed;
	public GameObject gameManager;
	private Vector3 paddlePosition;
	private Vector3 ballPosition;
	
	// Update is called once per frame
	void Update () {
		speed = gameManager.GetComponent<livesManager> ().level * 2;
		// get ball position
		ballPosition = ballToFollow.transform.position;
		// get vector between paddle and ball
		paddlePosition = transform.position;
		Vector3 paddleDirection = ballPosition - paddlePosition;
		paddleDirection.z = 0;
		// remove z component from vector
		// normalize vector
//		paddleDirection.Normalize();
		// multiply by speed
		paddleDirection *= speed;
		// apply to this
		transform.position += paddleDirection * Time.deltaTime;
	}
}

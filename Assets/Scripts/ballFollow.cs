using UnityEngine;
using System.Collections;

public class ballFollow : MonoBehaviour {

	public GameObject ballToFollow;
	public float speed;
	public GameObject gameManager;

	public GameObject topWall;
	public GameObject bottomWall;
	public GameObject leftWall;
	public GameObject rightWall;

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
		paddleDirection *= speed;
		// apply to this
		transform.position += paddleDirection * Time.deltaTime;

		transform.position = new Vector3 (
			Mathf.Clamp (
				transform.position.x,
				leftWall.transform.position.x + this.transform.lossyScale.x / 2,
				rightWall.transform.position.x - this.transform.lossyScale.x / 2
			),
			Mathf.Clamp (
				transform.position.y,
				bottomWall.transform.position.y + this.transform.lossyScale.y / 2,
				topWall.transform.position.y - this.transform.lossyScale.y / 2
			),
			transform.position.z
		);
	}
}

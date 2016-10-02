using UnityEngine;
using System.Collections;

public class handleCollision : MonoBehaviour {

	public GameObject ball;
	public GameObject gameManager;

	public enum SideEnum{Player, Enemy};
	public SideEnum Side;

	private Rigidbody rb;
	private Collider ballCollider;
	// Use this for initialization
	void Start () {
		ballCollider = ball.GetComponent<Collider>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider other) {
		if (other == ballCollider) {
			Debug.Log ("Wall hit");
			gameManager.GetComponent<livesManager> ().decrementLives (Side.ToString());
			ball.GetComponent<addInitalForce>().reInitialize ();
		}
	}


}

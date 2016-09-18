using UnityEngine;
using System.Collections;

public class StartVelocity : MonoBehaviour {

	public float speed;
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		rb.velocity = Random.insideUnitSphere * speed; //new Vector3(1.0f, 1.0f, 1.0f) * speed;
	}
}

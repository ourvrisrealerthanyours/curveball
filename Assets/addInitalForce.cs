using UnityEngine;
using System.Collections;

public class addInitalForce : MonoBehaviour {

	// Use this for initialization
	public float thrust;
	public Rigidbody rb;
	private Vector3 pos;
	private Vector3 vel;
	private Vector3 spin;
	void Start () {
		rb = GetComponent<Rigidbody> ();
		rb.AddForce (2, 4, 10, ForceMode.Impulse);
		rb.angularVelocity = new Vector3 (0f, 0.6f);
	}
	
	// Update is called once per frame
	void Update () {
		pos = transform.position;
		vel = rb.velocity;
		spin = rb.angularVelocity;
//		rb.AddForce (-pos.x * 4f, (-pos.y + 5f) * 4f, 0f);
//		Debug.Log(Vector3.Cross(spin, vel));
		rb.AddForce (Vector3.Cross(vel, spin));
	}
}
	
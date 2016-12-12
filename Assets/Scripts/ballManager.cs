using UnityEngine;
using System.Collections;

public class ballManager : MonoBehaviour {

	// Use this for initialization
	public float thrust;
	public GameObject gameManager;
	public float maxZSpeed;
	private Rigidbody rb;
	private Vector3 spin;
	private Vector3 velZ;

	void Start () {
		rb = GetComponent<Rigidbody> ();
//		rb.AddForce (2, 4, 10, ForceMode.Impulse);
//		rb.angularVelocity = new Vector3 (0f, 0.6f);
		reset();
		spank ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Mathf.Abs(rb.velocity.z) > maxZSpeed) {
			var velz = maxZSpeed * rb.velocity.z / Mathf.Abs(rb.velocity.z);
			rb.velocity = new Vector3 (rb.velocity.x, rb.velocity.y, velz);
		}


		velZ = new Vector3 (0f, 0f, rb.velocity.z);
		spin = rb.angularVelocity;
		rb.AddForce (Vector3.Cross(velZ, spin));
	}

	public void reset() {
		rb.velocity = Vector3.zero;
		rb.angularVelocity = Vector3.zero;
//		transform.position = new Vector3 (0f, 5f, 0f);
	}

	public void spank () {
//		rb.AddForce (2, 4, 10, ForceMode.Impulse);
		rb.transform.position = new Vector3(0f, 5f, -20f);
	}

	public void pause () { 
		Debug.Log ("Pausing");

		rb.velocity = Vector3.zero;
		rb.angularVelocity = Vector3.zero;
	}
}
	
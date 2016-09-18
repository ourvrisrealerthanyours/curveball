using UnityEngine;
using System.Collections;

public class Bouncy : MonoBehaviour {
	
	public float bounciness;
	private Vector3 lastVelocity;
	private Rigidbody rb;

	public void Start()
	{
		rb = GetComponent<Rigidbody> ();
		bounciness = Mathf.Clamp(bounciness, 0.0f, 1.0f);
	}

	void FixedUpdate()
	{
		if (rb) {
			lastVelocity = rb.velocity;
		}
	}

	void OnCollisionEnter(Collision collision)
	{
		Vector3 normal = Vector3.zero;

		foreach(ContactPoint c in collision.contacts)
		{
			normal += c.normal;
		}

		normal.Normalize();
		Vector3 inVelocity = lastVelocity;
		Vector3 outVelocity = bounciness * ( -2.0f * (Vector3.Dot(inVelocity,normal) * normal) + inVelocity );
		rb.velocity = outVelocity;
	}
}
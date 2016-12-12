using UnityEngine;
using System.Collections;

public class ignorePaddle : MonoBehaviour {
	public GameObject paddle;

	// Use this for initialization
	void Start () {
		Physics.IgnoreCollision (GetComponent<Collider> (), paddle.GetComponent<Collider> ());
	}

}

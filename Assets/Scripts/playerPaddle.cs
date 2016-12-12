using UnityEngine;
using System.Collections;

public class playerPaddle : MonoBehaviour {
	public GameObject steamController;
	private Vector3	controllerPos;
	private FixedJoint fj;
	// Use this for initialization
	void Start () {
		controllerPos = steamController.transform.position;
		Debug.Log (controllerPos);
		transform.position = controllerPos;
		fj = GetComponent<FixedJoint> ();
		fj.enableCollision = true;
		fj.enableCollision = false;
	}
	
	// Update is called once per frame
	void Update () {
	}
}

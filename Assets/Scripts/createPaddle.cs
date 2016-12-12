using UnityEngine;
using System.Collections;

[RequireComponent(typeof(SteamVR_TrackedObject))]
public class createPaddle : MonoBehaviour {

	public GameObject prefab;
	public Rigidbody attachPoint;

	SteamVR_TrackedObject trackedObj;
	FixedJoint joint;
	GameObject paddle;

	void Awake()
	{
		Debug.Log("awake");
////		attachPoint = GetComponent<Rigidbody> ();
		trackedObj = GetComponent<SteamVR_TrackedObject>();
//		var paddle = GameObject.Instantiate(prefab);
//		paddle.transform.position = attachPoint.transform.position;
//		Debug.Log (attachPoint.transform.position);
//
//		joint = paddle.AddComponent<FixedJoint>();
//		joint.connectedBody = attachPoint;
	}

	void FixedUpdate() {
		var device = SteamVR_Controller.Input((int)trackedObj.index);
		if (joint == null && device.GetTouchDown(SteamVR_Controller.ButtonMask.Trigger)) {
			paddle = GameObject.Instantiate (prefab);
			paddle.transform.position = attachPoint.transform.position;
			joint = paddle.AddComponent<FixedJoint>();
			joint.connectedBody = attachPoint;
//			var rb = paddle.GetComponent<Rigidbody> ();
		}
//		Debug.Log ("Fixed update");
//		paddle.transform.position = attachPoint.transform.position;
//		Debug.Log (attachPoint.transform.position);
	}
}

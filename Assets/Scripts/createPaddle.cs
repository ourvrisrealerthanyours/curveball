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
		trackedObj = GetComponent<SteamVR_TrackedObject>();
	}

	void FixedUpdate() {
		var device = SteamVR_Controller.Input((int)trackedObj.index);
		if (joint == null && device.GetTouchDown(SteamVR_Controller.ButtonMask.Trigger)) {
			paddle = GameObject.Instantiate (prefab);
			paddle.transform.position = attachPoint.transform.position;
			paddle.transform.rotation = attachPoint.transform.rotation;
			joint = paddle.AddComponent<FixedJoint>();
			joint.connectedBody = attachPoint;
		}
	}
}

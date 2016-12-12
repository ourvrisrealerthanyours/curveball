using UnityEngine;
using System.Collections;


[RequireComponent(typeof(SteamVR_TrackedObject))]
public class controllerRight : MonoBehaviour {

	public GameObject paddle;
	public GameObject prefab;
	public Rigidbody attachPoint;

	SteamVR_TrackedObject trackedObj;
	FixedJoint joint;

	// Use this for initialization
//
//	void Awake()
//	{
//		trackedObj = GetComponent<SteamVR_TrackedObject>();
//	}

	void Start () {
		paddle.transform.position = transform.position;
		paddle.GetComponent<FixedJoint> ().enableCollision = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

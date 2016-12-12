using UnityEngine;
using System.Collections;

public class ignoreWalls : MonoBehaviour {
	public GameObject floor;
	// Use this for initialization
	void Start () {
		Physics.IgnoreCollision(GetComponent<Collider>(), floor.GetComponent<Collider>());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

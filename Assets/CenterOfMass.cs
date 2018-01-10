using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterOfMass : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Collider center = GetComponent<Collider>();
        center.attachedRigidbody.centerOfMass = new Vector3(0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

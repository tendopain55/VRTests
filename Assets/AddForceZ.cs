using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceZ : MonoBehaviour {

    // Use this for initialization
    void Start() {
        GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 100));
	}
	
	void FixedUpdate () {
		
	}
}

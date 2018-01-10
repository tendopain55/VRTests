using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrueFriction : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Collider>().material.dynamicFriction = 0;
        GetComponent<Collider>().material.staticFriction = 0;
        GetComponent<Collider>().material.frictionCombine = 0;
        GetComponent<Rigidbody>().angularDrag = 0;
        GetComponent<Rigidbody>().drag = 0;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        GetComponent<Collider>().material.dynamicFriction = 0;
        GetComponent<Collider>().material.staticFriction = 0;
        GetComponent<Collider>().material.frictionCombine = 0;
        GetComponent<Rigidbody>().angularDrag = 0;
        GetComponent<Rigidbody>().drag = 0;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMan : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Rigidbody snowman = this.GetComponent<Rigidbody>();
        snowman.AddRelativeTorque(0, 45, 0);
    }
	
	// Update is called once per frame
	void Update () {
        // this.transform.Rotate(0, 4, 0);
        
	}
}

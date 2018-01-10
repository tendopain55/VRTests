using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frictionless : MonoBehaviour {
    
    private float speed;
    private float totalEnergy;
    private float potentialEnergy;
    private float kineticEnergy;
    // Use this for initialization
    void Start () {
        speed = 0;
        potentialEnergy = GetComponent<Rigidbody>().mass * 9.81f * transform.localPosition.y;
        kineticEnergy = 0.5f * GetComponent<Rigidbody>().mass * Mathf.Pow(speed, 2);
        totalEnergy = potentialEnergy + kineticEnergy;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        potentialEnergy = GetComponent<Rigidbody>().mass * 9.81f * transform.localPosition.y;
        kineticEnergy = totalEnergy - potentialEnergy;
        speed = Mathf.Sqrt(kineticEnergy * 2 * GetComponent<Rigidbody>().mass);
        GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody>().velocity.normalized * speed;
    }
}

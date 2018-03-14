using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbits : MonoBehaviour {
    public Rigidbody rb;
    public Rigidbody center;
    public bool clockwise;
	
	void Start () {
        rb = GetComponent<Rigidbody>();
        double velocity = 0.0;
        velocity = System.Math.Sqrt(System.Math.Pow(6.674, -11.0) * center.mass / (center.position - this.transform.position).magnitude);
        if (clockwise) {
            rb.velocity = new Vector3(0, 0, (float) velocity);
        } else
        {
            rb.velocity = new Vector3(0, 0, (float)velocity);
        }
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        double force = System.Math.Pow(6.674, -11.0) * rb.mass * center.mass / ((center.position - this.transform.position).magnitude * (center.position - this.transform.position).magnitude)*100000;
        rb.AddForce((center.position - this.transform.position).normalized*(float)force);
	}
}

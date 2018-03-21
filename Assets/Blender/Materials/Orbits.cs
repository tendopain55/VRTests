using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NewtonVR;

public class Orbits : MonoBehaviour {
    public Rigidbody rb;
    public Rigidbody center;
    public bool clockwise;
    private NVRInteractableItem item;
	private Vector3 lastPos;
	void Start () {
        rb = GetComponent<Rigidbody>();
        item = GetComponent<NVRInteractableItem>();
        lastPos = center.transform.position;
        float initV = Mathf.Sqrt(center.mass / (center.position - this.transform.position).magnitude);
        InitialVelocity();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        item.OnEndInteraction.AddListener(InitialVelocity);
        this.transform.position += center.transform.position - lastPos;
        float r = Vector3.Distance(center.transform.position, this.transform.position);
        float forceVal = -(center.mass * this.rb.mass) / (r * r);
        Vector3 force = (this.transform.position - center.transform.position).normalized * forceVal;
        rb.AddForce(force);
        lastPos = center.transform.position;
	}
    void InitialVelocity()
    {
        float initV = Mathf.Sqrt(center.mass / (center.position - this.transform.position).magnitude);
        if (clockwise)
        {
            rb.velocity = Vector3.Cross((center.position - this.transform.position), new Vector3(0, 1, 0)).normalized * initV;

        }
        else
        {
            rb.velocity = Vector3.Cross((center.position - this.transform.position), new Vector3(0, 1, 0)).normalized * -initV;
        }
    }
}

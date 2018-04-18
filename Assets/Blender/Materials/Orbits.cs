using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NewtonVR;

public class Orbits : MonoBehaviour {
    public Rigidbody rb;
    public Rigidbody center;
    public bool clockwise;
    private NVRInteractableItem centerItem;
    private NVRInteractableItem item;
	private Vector3 lastPos;
    public Orbits innerOrbit;
    private bool update = true;
	void Start () {
        rb = GetComponent<Rigidbody>();
        item = GetComponent<NVRInteractableItem>();
        centerItem = center.GetComponent<NVRInteractableItem>();
        lastPos = center.position;
        float initV = Mathf.Sqrt(center.mass / (center.position - this.rb.position).magnitude);
        InitialVelocity();
        item.OnEndInteraction.AddListener(resetV);
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (centerItem != null)
        {
            if (centerItem.IsAttached)
            {
                if (innerOrbit != null)
                {
                    innerOrbit.update = false;
                }
                this.rb.position += center.position - lastPos;
                lastPos = center.position;
                pauseV();
                return;
            }
        }
        if (update)
        {
            float r = Vector3.Distance(center.position, this.rb.position);
            float forceVal = -(center.mass * this.rb.mass) / (r * r);
            Vector3 force = (this.rb.position - center.position).normalized * forceVal;
            rb.AddForce(force);
        }
	}
    void InitialVelocity()
    {
        if(innerOrbit != null){
            innerOrbit.update = true;
        }
        float initV = Mathf.Sqrt(center.mass / (center.position - this.rb.position).magnitude);
        if (clockwise)
        {
            rb.velocity += Vector3.Cross((center.position - this.rb.position), new Vector3(0, 1, 0)).normalized * initV;

        }
        else
        {
            rb.velocity += Vector3.Cross((center.position - this.rb.position), new Vector3(0, 1, 0)).normalized * -initV;
        }
    }

    void resetV()
    {
        this.rb.velocity = new Vector3(0,0,0);
        InitialVelocity();
    }

    void pauseV()
    {
        this.rb.velocity = new Vector3(0, 0, 0);
    }
}

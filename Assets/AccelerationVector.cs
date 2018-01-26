using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vectrosity;
using NewtonVR;

public class AccelerationVector : MonoBehaviour {
    public Color linecolor = Color.blue;
    public Rigidbody rb;
    private NVRInteractableItem i;
    private Vector3 lastVelocity;
    private VectorLine myLine;
    public float thickness = 5.0f;
    public float offsetX = 0.0f;
    public float offsetY = 0.0f;
    public float offsetZ = 0.0f;



    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        i = GetComponent<NVRInteractableItem>();
        lastVelocity = rb.velocity;
        var linePoints = new List<Vector3>() { this.transform.position, this.transform.position }; ;
        myLine = new VectorLine("Line", linePoints, thickness, LineType.Discrete, Joins.Weld);
        myLine.color = linecolor;
        myLine.endCap = "Arrow";
        myLine.Draw3DAuto();
    }

    // Update is called once per frame

    void Update()
    {
        if (i.IsAttached)
        {
            myLine.points3[1] = this.transform.position;
            myLine.points3[0] = this.transform.position;
        } else
        {
            Vector3 acceleration = ((rb.velocity - lastVelocity) / Time.deltaTime)/5;
            lastVelocity = rb.velocity;
            myLine.points3[1] = this.transform.position;
            myLine.points3[0] = acceleration + this.transform.position;
        }
    }
}

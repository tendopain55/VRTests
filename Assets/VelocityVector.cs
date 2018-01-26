using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vectrosity;
using NewtonVR;
//Completely unfinished
//meant to only be used with Vectorlines on an empty object
public class VelocityVector : MonoBehaviour {
    public Color linecolor = Color.red;
    public Rigidbody rb;
    private VectorLine myLine;
    private NVRInteractableItem i;
    public float thickness = 5.0f;
    public float offsetX = 0.0f;
    public float offsetY = 0.0f;
    public float offsetZ = 0.0f;



    // Use this for initialization
    void Start()
    {
        i = GetComponent<NVRInteractableItem>();
        rb = GetComponent<Rigidbody>();
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
        }
        else
        {
            myLine.points3[1] = this.transform.position;
            myLine.points3[0] = rb.velocity/5 + this.transform.position;
        }
    }


}
